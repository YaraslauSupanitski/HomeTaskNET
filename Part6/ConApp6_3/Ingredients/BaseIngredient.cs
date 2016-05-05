using ConApp6_3.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_3.Ingredients
{
    abstract class BaseIngredient : BasePizza
    {
        protected BasePizza pizza;
        protected string IngredientName { get; set; }
        public decimal IngPrice { get; set; }


        public BaseIngredient() { }

        public BasePizza addIngred(BasePizza pizza)
        {
            this.pizza = pizza;
            this.pizza.PizzaPrice = this.pizza.PizzaPrice + this.IngPrice;
            pizza.Additives.Add(IngredientName);
            return this.pizza;
        }
    }
}
