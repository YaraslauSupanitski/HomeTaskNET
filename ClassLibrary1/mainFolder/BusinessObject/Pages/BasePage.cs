using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask3
{
    public abstract class BasePage
    {
        public BasePage()
        {
            //...
        }
        public abstract bool LoadPageBool();
        public abstract void LoadPage();
    }
}
