using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4_4
{
    class Market
    {
        private IList<Goods> basket = new List<Goods>(); 

        public void AddGood(Goods goods)
        {
            basket.Add(goods);
        }

        public void RemoveGood(string name)
        {
            foreach (Goods goods in basket)
            {
                if (goods.name.Equals(name))
                {
                    basket.Remove(goods);
                    break;
                }
            }
            
        }

        public int AllPrices()
        {
            int result = 0;
            foreach(Goods goods in basket)
                { 
                    result += goods.Price;
                }
            return result;
        }

        public override string ToString()
        {
            string result = String.Empty;
            foreach (Goods goods in basket)
            {
                result += goods + "\n";
            }
            return result.Trim();
        }
    }
}
