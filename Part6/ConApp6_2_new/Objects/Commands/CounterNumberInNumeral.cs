using ConApp6_2.Objects.Recirvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2.CommandsClasses
{
    class CounterNumberInNumeral : MathCommandAbstract
    {
        private CounterNumberInNumeralRecirver recirver;

        public CounterNumberInNumeral(CounterNumberInNumeralRecirver recirver) : base(recirver)
        {
            this.recirver = recirver;
        }


        public override void Execute()
        {
            Console.WriteLine($"Number = {recirver.numeral}, Sum = {recirver.SumNumberInNumeral()}");
        }

    }
}
