using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class MotorisedVehicle : Vehicle
    {
        public Engine Engine { get; set; }

        public MotorisedVehicle(string name, int speed, int maxPassengers, Engine engine) : base(name, speed, maxPassengers)
        {
            Engine = engine;
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine is starting!");
        }
    }
}
