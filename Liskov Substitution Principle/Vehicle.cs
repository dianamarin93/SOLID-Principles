using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int MaxPassengers { get; set; }

        public Vehicle(string name, int speed, int maxPassengers)
        {
            Name = name;
            Speed = speed;
            MaxPassengers = maxPassengers;
        }

        public override string ToString()
            => $"Name : {Name}, Speed: {Speed}, MaxPassengers: {MaxPassengers}";
    }
}
