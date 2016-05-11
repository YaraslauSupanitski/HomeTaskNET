using ConApp6_2.Objects.Recirvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2.CommandsClasses
{
    class NumberInfo : MathCommandAbstract
    {
        private NumberInfoRecirver recirver; 

        public NumberInfo(NumberInfoRecirver recirver):base(recirver)
        {
            this.recirver = recirver;
        }

        public override void Execute()
        {
            Console.WriteLine($"{recirver.number} Prime = {recirver.IsPrime()}");
        }


    }
}
