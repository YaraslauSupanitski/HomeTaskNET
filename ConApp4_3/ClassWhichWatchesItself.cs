using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4_3
{
    class ClassWhichWatchesItself
    {
        private static int _quontite = 0;

        public int QuontityPublic { get { return _quontite; } }

        public ClassWhichWatchesItself()
        {
            _quontite++;
        }

        /*
        ~ClassWhichWatchesItself()
        {
            _quontite--;
        }
        */
    }
}
