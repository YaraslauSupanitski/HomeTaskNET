using ConApp5_4_Ex_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConApp5_4_Ex_.Pages
{
    class StartPage : BasePage
    {
        public string pathPageData = $"{Environment.CurrentDirectory}\\..\\..\\Data\\PageData.xml";
        public string pathButtonsState = $"{Environment.CurrentDirectory}\\..\\..\\Data\\ButtonsState.xml";
        public List<Button> listButtonOnPage { get; set; }
        public List<Button> listButtonWithStatus { get; set; }

        //List<BaseElement> otherElements;

        public StartPage(List<Button> listButton, List<Button> listButtonForClick)
        {
            this.listButtonOnPage = listButton;
            this.listButtonWithStatus = listButtonForClick;
        }

            
        public StartPage(string pathPageData, string pathButtonsState)
        {
            this.pathPageData = pathPageData;
            this.pathButtonsState = pathButtonsState;
            listButtonOnPage = generateButtonOnPage(this.pathPageData);
            GenerateButtonWithStatus(this.pathButtonsState);
        }

        //list generators
        //create listButton
        public StartPage()
        {
            listButtonOnPage = generateButtonOnPage(pathPageData);
            GenerateButtonWithStatus(pathButtonsState);
        }
        //create listButtonWithStatus;
        private void GenerateButtonWithStatus(string pathButtonsState)
        {
            listButtonWithStatus = new List<Button>();
            XDocument xDoc = XDocument.Load(pathButtonsState);
            XElement root = xDoc.Root;

            root.Elements("button").ToList()
                .ForEach(el => 
                listButtonWithStatus.Add(new Button(el.Element("name").Value, el.Element("status").Value)));

        }
        

        //TaskManagers
        //1st Task
        public void ShowAllButtonInConsole()
        {
            listButtonOnPage.ForEach(but => Console.WriteLine(but.ToString()));
        }

        //2nd Task
        public bool ClickAllButtons(out string stringResult)
        {
            string stringRes = String.Empty;
            string stringButton = String.Empty;

            bool res = true;
            if (CheckTheSameButton())
            {

                foreach (var butForClick in listButtonOnPage)
                {
                    try
                    {
                        ClickOneButton(butForClick, out stringButton);
                    }
                    catch (FormatException e)
                    {
                        stringButton = e.Message;
                        res = false;
                    }
                    stringRes += stringButton + "\n";
                }
                
            };
            stringResult = stringRes;
            return res;
        }


        //helper to find exeption
        public bool ClickOneButton(Button butForClick, out string result)
        {
            bool res = false;
            int index;

            if ((index = listButtonWithStatus.IndexOf(butForClick)) == -1)
            {
                throw new FormatException($"{butForClick} = We havent this button in config");
            }

            else
            {
                if (!listButtonWithStatus.ElementAt(index).correctData)
                {
                    throw new FormatException($"{butForClick.ToString()} Invalid data in File");
                }

                butForClick.status = listButtonWithStatus.ElementAt(index).status;
                try
                {
                    result = butForClick.Click();
                    res = true;
                }
                catch (FormatException e)
                {
                    result = e.Message;
                }
            }
            return res;
        }

        private bool CheckTheSameButton()
        {
            bool res = true;
            var listButtonDistinct = (from bu in listButtonOnPage
                                      select bu.Name).Distinct();

            var listButtonForClickDistinct = (from bu in listButtonOnPage
                                              select bu.Name).Distinct();


            if ((listButtonOnPage.Count != listButtonDistinct.Count()))
            {
                throw new FormatException("We have similar button on PageData.xml. I cant work under such conditions");
            }
            else if (listButtonWithStatus.Count != listButtonForClickDistinct.Count())
            {
                throw new FormatException("We have similar button in ButtonsState.xml. I cant work under such conditions");
            }
            return res;
        }

    }
}
    

