using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee programmer = Factory.CreateEmployee("Diana", "Marin", "diana@email.com", "1234567890");

            Task task1 = Factory.CreateTask("Create new database", programmer);

            task1.Execute(2.0);
            task1.Execute(3.5);
            task1.CompleteTask();

            Console.ReadKey();
        }
    }
}
