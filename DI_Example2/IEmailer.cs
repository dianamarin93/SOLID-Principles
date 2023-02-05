using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example2
{
    interface IEmailer
    {
        void SendEmail(IEmployee employee, string message);
    }
}
