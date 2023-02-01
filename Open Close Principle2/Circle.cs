using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle2
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetShapePerimeter()
        => 2 * Math.PI * Radius;
        

        public override double GetShapeArea()
            => Math.PI * Math.Pow(Radius, 2);
        
    }
}
