using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5
{
    abstract class AbstractCollectionMeter
    {
        public abstract void adding(int num);
        public abstract void reading(int num);
        public abstract void removing(int num);
        public abstract void searching(int num);
    }
}
