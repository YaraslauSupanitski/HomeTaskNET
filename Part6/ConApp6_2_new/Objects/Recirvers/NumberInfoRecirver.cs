using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2.Objects.Recirvers
{
    class NumberInfoRecirver : BaseRecirver
    {
        public int number { get; set; }

        public NumberInfoRecirver() { }
        public NumberInfoRecirver(int num) { this.number = num; }


        public bool IsPrime()
        {
            bool result = true;

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
