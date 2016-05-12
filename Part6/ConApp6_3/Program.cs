using ConApp6_3.Ingredients;
using ConApp6_3.Pizzas;
using LibraryForConsole4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_3
{
    class Program
    {
        static void Main(string[] args)
        {


            string pizzaMessage = 
                        "Input 1 Cheese Pizza\n" +
                        "Input 2 Meat Pizza\n" +
                        "Input 3 Pepperoni\n";
            string addIngMessage = 
                        "Do you whant adding some ingredient?\n" +
                        "1 - Yes " +
                        "2 - no";
            string ingMessage = 
                        "Input 1 Mushrooms\n" +
                        "Input 2 Pepper\n" +
                        "Input 3 Pepperoni\n";
            string readyPizzaMessage = 
                        "Input 1 to cook this pizza and create new Pizza\n" +
                        "Input 2 to see Pizza\'s price\n" +
                        "Input 3 to see all ingredients in your pizza\n" +
                        "Input 4 for exit\n";
            int inputNum;


            BasePizza pizza;
            BaseIngredient ing;
            
            //can do new method. generator.
            Dictionary<int, BasePizza> pizzaDic = new Dictionary<int, BasePizza>();
            Dictionary<int, BaseIngredient> ingDic = new Dictionary<int, BaseIngredient>();

            pizzaDic.Add(1, new CheesePizza());
            pizzaDic.Add(2, new MeatPizza());
            pizzaDic.Add(3, new VeganPizza());

            ingDic.Add(1, new Mushrooms());
            ingDic.Add(2, new Pepper());
            ingDic.Add(3, new Pepperoni());
            


        PizzaQuestion:
            Console.WriteLine(pizzaMessage);
            inputNum = ConsoleWorker.getIntegerValue();
            pizza = pizzaDic[inputNum];
            Console.WriteLine($"You input {inputNum}. You have {pizza.PizzaName}");

        IngredientsQuestion:
            Console.WriteLine(addIngMessage);
            inputNum = ConsoleWorker.getIntegerValue();
            switch (inputNum) {
                case 1:
                    Console.WriteLine(ingMessage);
                    int ingNum = ConsoleWorker.getIntegerValue();
                    ing = ingDic[ingNum];
                    pizza = ing.addIngred(pizza);
                    goto IngredientsQuestion;
                case 2:
                    goto ReadyPizzaQuestion;
        }

        ReadyPizzaQuestion:
            Console.WriteLine(readyPizzaMessage);
            inputNum = ConsoleWorker.getIntegerValue();
            switch (inputNum)
            {
                case 1:
                    goto PizzaQuestion;
                case 2:
                    Console.WriteLine("Pizza price: " + pizza.PizzaPrice);
                    goto ReadyPizzaQuestion;
                case 3:
                    Console.WriteLine("Pizza ingridients: ");
                    pizza.Additives.ForEach(el => Console.WriteLine(el));
                    goto ReadyPizzaQuestion;
                case 4:
                    break;
            }
          

            Console.Read();
        }
    }
}
