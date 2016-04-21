using ClassLibrary1.mainFolder.BusinessObject.ElementsFolder.PagesElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.mainFolder.ElementsFolder.PagesElements
{
    class Form : BaseElement
    {
        private string formName = "form";

        public Form() : base()
        {
            this.elementName = "form";
        }


        public void FillField(string name, string mes)
        {
            SimpleElement field = FindElementByName(name);
            field.SetText(mes);
        }

        public SimpleElement FindElementByName(string name)
        {
            SimpleElement element = new SimpleElement(name);
            return element;
        }


        public override void Click()
        {
            throw new NotImplementedException();
        }

        public override void SetText(string text)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return formName;
        }
    }
}
