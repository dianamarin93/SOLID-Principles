using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle2
{
    class Triangle : Shape
    {
        public double Height { get; set; }
        public double BaseSide { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Triangle(double height, double baseSide, double side1, double side2)
        {
            Height = height;
            BaseSide = baseSide;
            Side1 = side1;
            Side2 = side2;
        }

        public override double GetShapePerimeter()
            => Side1 + Side2 + BaseSide;

        public override double GetShapeArea()
            => BaseSide * Height / 2;
    }
}
