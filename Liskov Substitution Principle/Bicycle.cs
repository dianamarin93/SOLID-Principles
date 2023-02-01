using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Bicycle : UnmotorisedVehicle
    {
        public Bicycle(string name, int speed, int maxPassengers) : base(name, speed, maxPassengers)
        {
        }
    }
}
