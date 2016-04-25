using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4_4
{
    class Goods
    {
        public int Price { set; get; }
        public string name;

        public Goods(string name)
        {
            this.name = name;
        }

        public Goods(string name, int price)
        {
            this.name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"name: {name}\tprice {Price}";
        }
    }
}
