using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5_2_2
{
    public static class ExtendBigInt
    {
        public static bool isSimple(this BigInteger num)
        {
            bool simple = true;

            if (num == 1)
            {
                simple = false;
            }
            else
            {
                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        simple = false;
                    }
                }
            }
            return simple;
        }
    }
}
