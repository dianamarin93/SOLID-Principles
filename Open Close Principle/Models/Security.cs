using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle.Models
{
    class Security : Employees
    {
        public Security(string firstName, string lastName, string department) : base(firstName, lastName, department)
        {
        }

        private void GuardTheDoor()
        {
            Console.WriteLine("Guarding the door!");
        }

        private void CheckReservations()
        {
            Console.WriteLine("Checking the reservation!");
        }

        public override void PerformDuties()
        {
            GuardTheDoor();
            CheckReservations();
        }
    }
}
