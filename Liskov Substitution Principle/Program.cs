using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorisedVehicle plane = new Plane("Airbus", 800, 220, new Engine("Turboprop", 30000));
            Console.WriteLine(plane);
            plane.StartEngine();

            MotorisedVehicle car = new Car("Dacia", 200, 5, new Engine("TCE", 2));
            Console.WriteLine(car);
            car.StartEngine();

            MotorisedVehicle train = new Train("LDE", 80, 150, new Engine("LDE", 2100));
            Console.WriteLine(train);
            train.StartEngine();

            UnmotorisedVehicle bicycle = new Bicycle("Pegas", 20, 1);
            Console.WriteLine(bicycle);
            
        }
    }
}
