using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5.Objects.DictionaryClasses
{
    class SortedDictionaryMeter : AbstractCollectionMeter
    {
        private SortedDictionary<int, int> sortedDictinary = new SortedDictionary<int, int>();

        public override void adding(int num)
        {
            for (int i = 0; i < num; i++)
            {
                sortedDictinary.Add(i, i);
            }
        }

        public override void reading(int num)
        {
            try
            {
                Console.Write(sortedDictinary[num]);
            }
            catch(Exception e)
            {

            }
            }

        public override void removing(int num)
        {
            sortedDictinary.Remove(num);
        }

        public override void searching(int num)
        {
            sortedDictinary.ContainsKey(num);
        }
    }
}
