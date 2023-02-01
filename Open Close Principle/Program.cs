using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open_Close_Principle.Models;

namespace Open_Close_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantManagement manager = new RestaurantManagement();
            Chef chef = new Chef("Bontea", "Sorin", "Kitchen");
            Waiter waiter = new Waiter("Alin", "Mandea", "Bar");
            Security security = new Security("Ghita", "Ioan", "Security");
            Janitor janitor = new Janitor("Ileana", "Adam", "Clean");
            

            manager.CallEmployee(chef);
            Console.WriteLine("-------------------------------------------");
            manager.CallEmployee(waiter);
            Console.WriteLine("-------------------------------------------");
            manager.CallEmployee(security);
            Console.WriteLine("-------------------------------------------");
            manager.CallEmployee(janitor);

            Console.WriteLine(chef);
            Console.WriteLine(waiter);
            Console.WriteLine(security);
            Console.WriteLine(janitor);

            Console.ReadKey();
        }
    }
}
