using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5.Objects.DictionaryClasses
{
    class DictionaryMeter : AbstractCollectionMeter
    {
        private Dictionary<int,int> dictinary = new Dictionary<int,int>();

        public override void adding(int num)
        {
            for (int i = 0; i < num; i++)
            {
                dictinary.Add(i, i);
            }
        }

        public override void reading(int num)
        {
            try{
                Console.Write(dictinary[num] - 1);
            }
            catch (Exception e)
            {

            }
            }

        public override void removing(int num)
        {
            dictinary.Remove(num);
        }

        public override void searching(int num)
        {
            dictinary.ContainsKey(num);
        }
    }
}
