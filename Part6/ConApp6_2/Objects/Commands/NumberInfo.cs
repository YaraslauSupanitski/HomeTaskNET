using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2.CommandsClasses
{
    class NumberInfo : MathCommandAbstract
    {
        public int number;


        public NumberInfo(){}
        public void setNumber(int num) { this.number = num; }

        public NumberInfo(int num)
        {
            number = num;
        }

        public override void Execute()
        {
            Console.WriteLine($"{number} Prime = {IsPrime(number)}");
        }

        public override void SetParams(params int[] list)
        {
            setNumber(list[0]);
        }

        private bool IsPrime(int num)
        {
            bool result = true;

            for (int i = 2; i < num-1; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
