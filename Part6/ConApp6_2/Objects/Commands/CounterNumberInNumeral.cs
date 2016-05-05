using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2.CommandsClasses
{
    class CounterNumberInNumeral : MathCommandAbstract
    {
        public int number;


        public CounterNumberInNumeral() { }
        public void setNumber(int num) { this.number = num; }

        public CounterNumberInNumeral(int num)
        {
            this.number = num;
        }

        public override void Execute()
        {
            Console.WriteLine($"Number = {number}, Sum = {SumNumberInNumeral(number)}");
        }

        public override void SetParams(params int[] list)
        {
            setNumber(list[0]);
        }

        private int SumNumberInNumeral(int numeral)
        {
            string w = numeral.ToString();
            var e = w.ToList();
            return numeral.ToString().ToList().Sum(number => Int32.Parse(number.ToString()));
        }
    }
}
