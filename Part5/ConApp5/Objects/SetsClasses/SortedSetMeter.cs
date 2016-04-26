using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5.Objects
{
    class SortedSetMeter : AbstractCollectionMeter
    {
        private SortedSet<int> sortedSet = new SortedSet<int>();

        public override void adding(int num)
        {
            for (int i = 0; i < num; i++)
            {
                sortedSet.Add(i);
            }
        }

        public override void reading(int num)
        {
            sortedSet.Contains(num);
        }

        public override void removing(int num)
        {
            sortedSet.Remove(num);
        }

        public override void searching(int num)
        {
            throw new NotImplementedException();
        }
    }
}
