using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy_Inversion_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog(new DogSpeak());
            Animal cat = new Cat(new CatSpeak());
            Animal cow = new Cow(new CowSpeak());

            Console.WriteLine(dog.MakeSound());
            Console.WriteLine(cat.MakeSound());
            Console.WriteLine(cow.MakeSound());
        }
    }
}
