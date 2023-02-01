using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    class Printer
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public Printer(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }

        public override string ToString()
            => $"Brand: {Brand}, Color: {Color}";
    }
}
