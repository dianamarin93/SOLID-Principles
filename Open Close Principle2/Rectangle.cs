using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle2
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double GetShapePerimeter()
        => 2 * (Length + Width);

        public override double GetShapeArea()
       => Length * Width;
    }
}
