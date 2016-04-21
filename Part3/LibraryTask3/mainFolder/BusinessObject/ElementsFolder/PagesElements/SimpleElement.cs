using ClassLibrary1.mainFolder.ElementsFolder;
using ClassLibrary1.mainFolder.ElementsFolder.PagesElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.mainFolder.BusinessObject.ElementsFolder.PagesElements
{
    class SimpleElement : BaseElement
    {
        
        public SimpleElement() : base()
        {
        }
        public SimpleElement(string name) : base()
        {
            this.elementName = name;
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
            return this.elementName;
        }
    }
}
