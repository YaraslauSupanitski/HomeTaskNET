using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConApp5.Objects
{
    class Worker
    {
        private Stopwatch sWatch = new Stopwatch();
        private string result = String.Empty;

        public string adding(AbstractCollectionMeter ab,int num)
        {
            sWatch.Start();
            ab.adding(num);
            sWatch.Stop();
            result = sWatch.Elapsed.ToString();

            return getNameClass(ab,result);
        }

        public string reading(AbstractCollectionMeter ab, int num) {
            sWatch.Start();
            ab.reading(num);
            sWatch.Stop();
            result = sWatch.Elapsed.ToString();

            return getNameClass(ab, result);
        }

        public string removing(AbstractCollectionMeter ab, int num)
        {
            sWatch.Start();
            ab.removing(num);
            sWatch.Stop();
            result = sWatch.Elapsed.ToString();

            return getNameClass(ab, result);
        }

        public string searching(AbstractCollectionMeter ab, int num) {

            sWatch.Start();
            ab.searching(num);
            sWatch.Stop();
            result = sWatch.Elapsed.ToString();

            return ab.GetType().ToString().LastIndexOf('.') + "\t" + result;

        }

        private string getNameClass(AbstractCollectionMeter ab, string result)
        {
            string fullName = ab.GetType().ToString();
            string startName = fullName.Substring(fullName.LastIndexOf('.') + 1);
            string normalName = startName.Substring(0, startName.LastIndexOf('M'));

            return normalName + " = " + result;
        }

    }
}
