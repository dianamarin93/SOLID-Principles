using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double DesiredSalary { get; set; }
        public string DesiredJob { get; set; }

        public Person(string firstName, string lastName, double desiredSalary, string desiredJob)
        {
            FirstName = firstName;
            LastName = lastName;
            DesiredSalary = desiredSalary;
            DesiredJob = desiredJob;
        }
    }
}
