using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example2
{
    interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
    }
}
