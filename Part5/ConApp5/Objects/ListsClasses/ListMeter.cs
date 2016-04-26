using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5.Objects
{
    class ListMeter : AbstractCollectionMeter
    {
        private List<int> list = new List<int>();

        public ListMeter()
        {
        }

        public override void adding(int num)
        {
            for (int i = 0; i < num; i++)
            {
                list.Add(i);
            }
        }

        public override void reading(int num)
        {
            list.Contains(num);
        }

        public override void removing(int num)
        {
            list.Remove(num);
        }

        public override void searching(int num)
        {
            throw new NotImplementedException();
        }
    }
}
