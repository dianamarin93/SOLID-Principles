using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    class Engine
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Engine(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public override string ToString()
            => $"Name: {Name}, Capacity: {Capacity}";
    }
}
