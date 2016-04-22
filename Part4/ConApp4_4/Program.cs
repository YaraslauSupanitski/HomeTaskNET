using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market();

            Goods g1 = new Goods("g1", 1);
            Goods g2 = new Goods("g2", 2);
            Goods g3 = new Goods("g3", 3);
            Goods g4 = new Goods("g4", 4);

            market.AddGood(g1);
            market.AddGood(g2);
            market.AddGood(g3);
            market.AddGood(g4);

            Console.WriteLine(market);
            Console.WriteLine("All price:" + market.AllPrices());

            Console.WriteLine();
            market.RemoveGood("g2");

            Console.WriteLine(market);
            Console.WriteLine("All price:" + market.AllPrices());

            Console.Read();
        }
    }
}
