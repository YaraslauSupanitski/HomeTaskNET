using ClassLibrary1.mainFolder.Pages.SitePages;
using LibraryTask3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.mainFolder.BusinessLogic
{
    class Registration
    {
        public void RegistrationPerson(string name, int age)
        {
            BasePage loginPage = new LoginPage();
            loginPage.LoadPageBool();

        }
    }
}
