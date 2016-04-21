using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.mainFolder.ElementsFolder.PagesElements
{
    class Form : BaseElement
    {
        private string formName;

        public Form() : base()
        {
            FindFormName();
        }

        private void FindFormName()
        {
            string formName = String.Empty;
            //...
            this.formName = formName;
        }


        public void FillInfo(string parameters) { }

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
