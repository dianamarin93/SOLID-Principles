using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class EmployeeDatabase
    {
        public static List<Person> employees = new List<Person>();

        public static void Add(Person employee)
        {
            employees.Add(employee);
        }
    }
}
