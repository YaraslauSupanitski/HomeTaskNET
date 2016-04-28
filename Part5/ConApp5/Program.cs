using ConApp5.Objects;
using ConApp5.Objects.DictionaryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string methodName = String.Empty;
            
            string filePath = @"C:\Users\Yaraslau_Supanitski@epam.com\Desktop\Presentations\aaa.txt";

            int numberForTesting = 1000000;

            List<AbstractCollectionMeter> myCollections = new List<AbstractCollectionMeter>();



            //add All collection for test
            myCollections.Add(new DictionaryMeter());
            myCollections.Add(new SortedDictionaryMeter());
            myCollections.Add(new LinkedListMeter());
            myCollections.Add(new ListMeter());
            myCollections.Add(new QueueMeter());
            myCollections.Add(new StackMeter());
            myCollections.Add(new SortedSetMeter());

            Worker worker = new Worker();

            // chego eto on \n /n ne chitaet???
            Log.LoginInfo(filePath, "");
            Log.LoginInfo(filePath,DateTime.Now.ToString());
            methodName = "Adding";
            Log.LoginInfo(filePath,methodName);
            foreach (var coll in myCollections)
            {
                Log.LoginInfo(filePath,worker.adding(coll,numberForTesting));
            }

            Log.LoginInfo(filePath, "");
            methodName = "Reading";
            Log.LoginInfo(filePath, methodName);
            foreach (var coll in myCollections)
            {
                Log.LoginInfo(filePath,worker.reading(coll, numberForTesting));
            }


            Log.LoginInfo(filePath, "");
            methodName = "Removing";
            Log.LoginInfo(filePath,methodName);
            foreach (var coll in myCollections)
            {
                Log.LoginInfo(filePath,worker.removing(coll, numberForTesting));
            }

            Log.LoginInfo(filePath, "");
            methodName = "Searching";
            Log.LoginInfo(filePath,methodName);
            foreach (var coll in myCollections)
            {
                Log.LoginInfo(filePath,worker.removing(coll, numberForTesting));
            }

        }
    }
}
