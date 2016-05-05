using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_3.Pizzas
{
    abstract class BasePizza
    {

        public List<string> Additives = new List<string>();

        public string PizzaName{get;set;}
        private decimal pizzaPrise = 0;
        public decimal PizzaPrice
        {
            get { if (Additives.Count > 1) { return pizzaPrise * 95 / 100; } else { return pizzaPrise; }}
            set { pizzaPrise = value; }
        }

        public BasePizza() { }
    }
}
