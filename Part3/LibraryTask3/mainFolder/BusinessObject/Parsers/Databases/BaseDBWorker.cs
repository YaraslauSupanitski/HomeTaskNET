using ClassLibrary1.mainFolder.Interfaces.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.mainFolder.Parsers.Databases
{
    abstract class BaseDBWorker : IReadConfig
    {
        public string Read()
        {
            throw new NotImplementedException();
        }
    }
}
