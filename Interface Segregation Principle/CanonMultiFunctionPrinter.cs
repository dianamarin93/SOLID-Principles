using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    class CanonMultiFunctionPrinter : Printer, IPrintBothSidesTask, ICopyTask, IPrintTask, IScanTask
    {
        public CanonMultiFunctionPrinter(string brand, string color) : base(brand, color)
        {
        }

        public void Print(Content content)
        {
            Console.WriteLine($"Printing {content}");
        }

        public void Scan(Content content)
        {
            Console.WriteLine($"Scanning {content}");
        }

        public void Copy(Content content)
        {
            Console.WriteLine($"Copying {content}");
        }

        public void PrintBothSides(Content content)
        {
            Console.WriteLine($"Printing both sides {content}");
        }
    }
}
