using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryTask3;
using ClassLibrary1.mainFolder.BusinessObject.ElementsFolder.PagesElements;
using ClassLibrary1.mainFolder.ElementsFolder.PagesElements;

namespace ClassLibrary1.mainFolder.Pages.SitePages
{
    class LoginPage : BasePage
    {
        Form form = null;

        public LoginPage() : base()
        {
        }

        public void registration(string name, int age) {
            form.FillField("name", name);
            form.FillField("age", age.ToString());
            form.FindElementByName("save").Click();
        }

        public override void LoadPage()
        {
            throw new NotImplementedException();
        }

        public override bool LoadPageBool()
        {
            throw new NotImplementedException();
        }
    }
}
