using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Square(4.5);
            Shape circle = new Circle(2.3);
            Shape rectangle = new Rectangle(1.2, 2.5);
            Shape triangle = new Triangle(2.1, 2, 1.3, 1.5);
            
            Console.WriteLine(square.GetShapePerimeter());
            Console.WriteLine(square.GetShapeArea());
            Console.WriteLine("------------------------");
            Console.WriteLine(circle.GetShapePerimeter());
            Console.WriteLine(circle.GetShapeArea()); 
            Console.WriteLine("------------------------");
            Console.WriteLine(rectangle.GetShapePerimeter());
            Console.WriteLine(rectangle.GetShapeArea());
            Console.WriteLine("------------------------");
            Console.WriteLine(triangle.GetShapePerimeter());
            Console.WriteLine(triangle.GetShapeArea());

            Console.ReadKey();
        }
    }
}
