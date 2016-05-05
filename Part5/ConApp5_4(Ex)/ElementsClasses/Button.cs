using ConApp5_4_Ex_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5_4_Ex_.Classes
{
    class Button : BaseElement, IClickable
    {
        //many many constructors
        public Button(string name, bool status)
        {
            this.Name = name;
            this.status = status;
        }
        public Button(string name, string status)
        {
            this.Name = name;
            try
            {
                this.status = Boolean.Parse(status);
            } catch (FormatException e)
            {
                 Console.WriteLine($"{Name}: uncorrect status. {e.Message}");
                 this.correctData = false;
            }
        } //<=== main constructor for this task
        public Button(string name)
        {
            this.Name = name;

        }
        public Button()
        {

        }



        public string Click()
        {
            if (!this.status)
            {
                throw new FormatException($"{Name} element not clickable");
            }
            return this.Name;
        }




        public override bool Equals(object obj)
        {
            if (obj == null || typeof(Button) != obj.GetType())
            {
                return false;
            }

            Button b = (Button)obj;
            return this.Name.Equals(b.Name);

        }

        public override string ToString()
        {
            return $"Name: = {this.Name}";
        }

    }
}
