using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2.Objects.Recirvers
{
    class CounterNumberInNumeralRecirver : IBaseRecirver
    {
        public int numeral;

        public CounterNumberInNumeralRecirver() { }
        public CounterNumberInNumeralRecirver(int num) { this.numeral = num; }


        public int SumNumberInNumeral()
        {
            string w = numeral.ToString();
            var e = w.ToList();
            return numeral.ToString().ToList().Sum(number => Int32.Parse(number.ToString()));
        }

    }
}
