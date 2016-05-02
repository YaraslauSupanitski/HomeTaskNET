using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConApp5_2_2
{
    class DataGenerator
    {

        public List<BigInteger> FibonacciGenerator(int quantityOfNumber)
        {
            List<BigInteger> list = new List<BigInteger>();

            BigInteger previousNumber = 0;
            BigInteger nextNumber = 1;
            BigInteger number = 0;

            for (BigInteger i = 0; i < quantityOfNumber; i++)
            {
                number = nextNumber;
                list.Add(number);
                nextNumber += previousNumber;
                previousNumber = number;
            }
            return list;
        }
    }
}
