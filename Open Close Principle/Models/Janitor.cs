using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle.Models
{
    class Janitor : Employees
    {
        public Janitor(string firstName, string lastName, string department) : base(firstName, lastName, department)
        {
        }

        public override void PerformDuties()
        {
            CleanFloors();
            CleanToilets();
        }

        private void CleanFloors()
        {
            Console.WriteLine("Cleaning the floors!");
        }

        private void CleanToilets()
        {
            Console.WriteLine("Cleaning the toilets!");
        }
    }
}
