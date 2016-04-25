using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5.Objects
{
    class QueueMeter : AbstractCollectionMeter
    {
        private Queue<int> queue = new Queue<int>();

        public override void adding(int num)
        {
            for (int i = 0; i < num; i++)
            {
                queue.Enqueue(i);
            }
        }

        public override void reading(int num)
        {
            queue.Contains(num);
        }

        public override void removing(int num)
        {
            queue.Dequeue();
        }

        public override void searching(int num)
        {
            throw new NotImplementedException();
        }
    }
}
