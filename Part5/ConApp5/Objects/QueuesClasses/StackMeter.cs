using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5.Objects
{
    class StackMeter : AbstractCollectionMeter
    {
        private Stack<int> stack = new Stack<int>();

        public override void adding(int num)
        {
            for (int i = 0; i < num; i++)
            {
                stack.Push(i);
            }
        }

        public override void reading(int num)
        {
            stack.Contains(num);
        }

        public override void removing(int num)
        {
            stack.Pop();
        }

        public override void searching(int num)
        {
            throw new NotImplementedException();
        }
    }
}
