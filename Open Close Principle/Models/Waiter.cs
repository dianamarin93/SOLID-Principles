using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle
{
    public class Waiter : Employees
    {
        public Waiter(string firstName, string lastName, string department) : base(firstName, lastName, department)
        {
        }
        private void TakeOrders()
        {
            Console.WriteLine("Taking the food orders from the customers!");
        }

        private void ServeCustomers()
        {
            Console.WriteLine("Serving food to customers!");
        }

        private void CleanTables()
        {
            Console.WriteLine("Cleaning the tables!");
        }

        public override void PerformDuties()
        {
            TakeOrders();
            ServeCustomers();
            CleanTables();
        }
    }
}
