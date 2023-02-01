using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Train : MotorisedVehicle
    {
        public Train(string name, int speed, int maxPassengers, Engine engine) : base(name, speed, maxPassengers, engine)
        {
        }
    }
}
