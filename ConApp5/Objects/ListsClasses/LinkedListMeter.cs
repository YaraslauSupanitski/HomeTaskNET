using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5.Objects
{
    class LinkedListMeter : AbstractCollectionMeter
    {
        private LinkedList<int> linkedList = new LinkedList<int>();

        public LinkedListMeter()
        {
        }

        public override void adding(int num)
        {
            for (int i = 0; i < num; i++)
            {
                linkedList.AddLast(i);
            }

        }

        public override void reading(int num)
        {
            linkedList.Find(num);
        }

        public override void removing(int num)
        {
            linkedList.Remove(num);
        }

        public override void searching(int num)
        {
            throw new NotImplementedException();
        }
    }
}
