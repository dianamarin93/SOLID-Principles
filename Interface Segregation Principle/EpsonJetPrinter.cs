using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    class EpsonJetPrinter : Printer, IPrintBothSidesTask, IPrintTask
    {
        public EpsonJetPrinter(string brand, string color) : base(brand, color)
        {
        }

        public void Print(Content content)
        {
            Console.WriteLine($"Printing {content}");
        }

        public void PrintBothSides(Content content)
        {
            Console.WriteLine($"Printing both sides {content}");
        }
    }
}
