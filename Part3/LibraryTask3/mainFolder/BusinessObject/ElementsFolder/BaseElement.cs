using ClassLibrary1.mainFolder.Interfaces.LogInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.mainFolder.ElementsFolder
{
    public abstract class BaseElement : ILoggable 
    {
        public string elementName;

        public BaseElement(){
            //...
        }
        

        public abstract void Click();
        public abstract void SetText(string text);

        public void Log()
        {
            throw new NotImplementedException();
        }
    }
}

