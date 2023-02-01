using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle
{
    public abstract class Employees
    {
        // ToDO: create an autoincremented id started from 1;
        private static int idCounter = 1;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Department { get; set; }

        public Employees(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Id = idCounter++;
        }

        public override string ToString()
            => $"Employee [id: {Id} , first name: {FirstName} , last name: {LastName}, department: {Department}]";

        public abstract void PerformDuties();
    }
}
