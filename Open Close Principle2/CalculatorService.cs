using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle2
{
    class CalculatorService
    {
        public double GetPerimeter(Shape shape)
            => shape.GetShapePerimeter();

        public double GetArea(Shape shape)
            => shape.GetShapeArea();

    }
}
