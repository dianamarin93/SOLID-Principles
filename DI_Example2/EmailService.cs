﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example2
{
    class EmailService : IEmailer
    {
        public void SendEmail(IEmployee employee, string message)
        {
            Console.WriteLine($"Sending email to {employee.EmailAddress} with {message}");
        }
    }
}
