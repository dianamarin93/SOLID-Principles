using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle2
{
    class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double GetShapePerimeter()
           => 4 * Side;


        public override double GetShapeArea()
        => Side * Side;
    }
}
