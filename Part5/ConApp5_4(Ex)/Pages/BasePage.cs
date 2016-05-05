using ConApp5_4_Ex_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConApp5_4_Ex_.Pages
{
    abstract class BasePage
    {
        protected List<Button> generateButtonOnPage(string dataPath)
        {
            List<Button> buttonList = new List<Button>();

            XDocument xDoc = XDocument.Load(dataPath);
            XElement rootElement = xDoc.Root;

            rootElement.Element("buttons")
                            .Elements("button").ToList()
                              .ForEach(but => buttonList.Add(
                                                new Button(but.Element("name").Value)));
            return buttonList;
        }

    }
}
