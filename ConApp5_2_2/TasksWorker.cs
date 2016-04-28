using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConApp5_2_2
{
    class TasksWorker
    {

        private List<BigInteger> dataList;

        //rdy
        public List<BigInteger> SimpleNumbers()
        {
            var listWithSimpleNum = dataList.Where(num => isSimple(num) == true).Select(num => num).ToList();
            return listWithSimpleNum;
        }

        //rdy
        public List<BigInteger> DividedBySumOfNumbers()
        {
            
            var listResult = dataList.Where(num => num % num.ToString().ToList()
                                        .Sum(strNum => long.Parse(strNum.ToString())) == 0).ToList();
            return listResult;
        }

        //rdy
        public bool IsDividedFive()
        {
            bool result = false;
            result = dataList.Any(num => num % 5 == 0);
            return result;
        }

        public IEnumerable<IGrouping<BigInteger,BigInteger>> SquareRoots(int numForFlag)
        {
            var resultList = dataList.Where(num => num.ToString().Contains(numForFlag.ToString()))
                                    .GroupBy(numWithTwo => (BigInteger)Math.Exp(BigInteger.Log(numWithTwo)/2));
            return resultList;
        }

        public List<BigInteger> SortBySecondNumber()
        {
            var listResult = dataList.Where(num => num >= 10).OrderByDescending(num => num.ToString()[1]).ToList();
            //listResult.OrderByDescending(num => num.ToString()[1]);  Почему лист н е сортирует лист, и возращшает старое значение
            return listResult;
        }
        /*
        public void DividedByInEnd()
        {
            var listResult = dataList.Where(num => num >=10)
                .Where(num => Int32.Parse(num.ToString().Substring(num.ToString().Length-2)) % 3 == 0)
                .);
        }
                  */


        public BigInteger DividedBySquareOfNumbers()
        {
            var aw = dataList.GroupBy(num => num.ToString().ToList().
                                            Sum(el => (int.Parse(el.ToString())) * (int.Parse(el.ToString()))));
            int max = 0;
            BigInteger result = 0;

            //badbadbad
            foreach (var i in aw)
            {
                if (i.Key > max)
                {
                    max = i.Key;
                    foreach (var a in i)
                    {
                        result = a;
                    }
                }
            }
            

            return result;

        }/*
               List<BigInteger> fibonacciSequence = FibonacciSequence.Fibonacci(count);
            var sortedNumbers =
                from number in fibonacciSequence
                orderby number.ToString().ToList().Sum(el => (int.Parse(el.ToString())) * (int.Parse(el.ToString())))
                select number;

            return sortedNumbers.ToList().Last();
        }
        */
        //BAD WORK
        public double ZeroCounter()
        {
            var a = dataList.Average(num => num.ToString().ToList()
                               .Count(numCh => numCh == '0'));
            return a;

        }


        //Helper for data manager
        public void refreshDataList(int num)
        {
            dataList = new DataGenerator().FibonacciGenerator(num);
        }

        private bool isSimple(BigInteger num)
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
