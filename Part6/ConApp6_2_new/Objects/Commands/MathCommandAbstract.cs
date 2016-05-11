using ConApp6_2.Objects.Recirvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp6_2
{
    abstract class MathCommandAbstract : ICommand
    {

        public MathCommandAbstract(BaseRecirver baseResirver)
        {
        }

        public abstract void Execute();

    }
}
