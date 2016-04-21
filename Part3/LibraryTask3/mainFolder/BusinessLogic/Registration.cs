﻿using ClassLibrary1.mainFolder.BusinessObject.ElementsFolder.PagesElements;
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
        private string name;
        private int age;

        public void RegistrationPerson(string name, int age)
        {
            saveInfo(name, age);
            LoginPage loginPage = new LoginPage();
            loginPage.registration("artem",11);

        }

        public void saveInfo(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
