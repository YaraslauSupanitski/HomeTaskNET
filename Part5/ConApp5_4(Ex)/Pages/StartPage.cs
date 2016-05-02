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
        public List<Button> listButton { get; set; }
        public List<Button> listButtonForClick { get; set; }

        List<BaseElement> otherElements;

        public StartPage(List<Button> listButton, List<Button> listButtonForClick)
        {
            this.listButton = listButton;
            this.listButtonForClick = listButtonForClick;
        }

        public StartPage(string pathPageData, string pathButtonsState)
        {
            this.pathPageData = pathPageData;
            this.pathButtonsState = pathButtonsState;
            listButton = generateButton(this.pathPageData);
            fillButtonStatus(this.pathButtonsState);
        }

        //list generators
        //create listButton
        public StartPage()
        {
            listButton = generateButton(pathPageData);
            fillButtonStatus(pathButtonsState);
        }
        //create listButtonForClick;
        private void fillButtonStatus(string pathButtonsState)
        {
            listButtonForClick = new List<Button>();
            XDocument xDoc = XDocument.Load(pathButtonsState);
            XElement root = xDoc.Root;

            root.Elements("button").ToList()
                .ForEach(el => 
                listButtonForClick.Add(new Button(el.Element("name").Value, el.Element("status").Value)));

        }
        

        //TaskManagers
        //1st Task
        public void ShowAllButtonInConsole()
        {
            listButton.ForEach(but => Console.WriteLine(but.ToString()));
        }

        //2nd Task
        public bool ClickOnAllButtons()
        {
            bool res = true;
            if (CheckTheSameButton())
            {

                foreach (var butForClick in listButton)
                {
                    try
                    {
                        ClickOnOneButton(butForClick);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        res = false;
                    }
                }
                
            };
            return res;
        }



        //helper to find exeption
        
        public bool ClickOnOneButton(Button butForClick)
        {
            bool res = false;
            int index;

            if ((index = listButtonForClick.IndexOf(butForClick)) == -1)
            {
                throw new FormatException($"{butForClick} = We havent this button in config");
            }

            else
            {
                if (!listButtonForClick.ElementAt(index).correctData)
                {
                    throw new FormatException($"{butForClick.ToString()} Invalid data in File");
                }

                butForClick.status = listButtonForClick.ElementAt(index).status;
                try
                {
                    Console.WriteLine(butForClick.Click());
                    res = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return res;
        }

        private bool CheckTheSameButton()
        {
            bool res = true;
            var listButtonDistinct = (from bu in listButton
                                      select bu.Name).Distinct();

            var listButtonForClickDistinct = (from bu in listButton
                                              select bu.Name).Distinct();


            if ((listButton.Count != listButtonDistinct.Count()))
            {
                throw new FormatException("We have similar button on PageData.xml. I cant work under such conditions");
            }
            else if (listButtonForClick.Count != listButtonForClickDistinct.Count())
            {
                throw new FormatException("We have similar button in ButtonsState.xml. I cant work under such conditions");
            }
            return res;
        }

    }
}
    

