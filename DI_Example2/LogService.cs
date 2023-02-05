using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example2
{
    class LogService : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
