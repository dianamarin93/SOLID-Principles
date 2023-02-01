using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.Services
{
    public class LogService
    {
        public void LogEmployee(Person person)
        {
            EmployeeDatabase.Add(person);
            Console.WriteLine($"{person.FirstName} {person.LastName} was successfully added in the EmployeeDatabase!");
        }

    }
}
