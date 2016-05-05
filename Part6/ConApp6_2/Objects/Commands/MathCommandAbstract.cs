using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2
{
    abstract class MathCommandAbstract : ICommand
    {
        public abstract void Execute();

        public abstract void SetParams(params int[] list);
    }
}
