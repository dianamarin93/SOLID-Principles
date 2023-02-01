using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.Services
{
    public class EmailService
    {
        public void SendEmail(Person person)
        {
            Console.WriteLine($"Congrats, {person.FirstName} {person.LastName}! You are hired!");
        }
    }
}
