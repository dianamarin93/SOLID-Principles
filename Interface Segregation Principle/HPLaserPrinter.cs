using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    class HPLaserPrinter : Printer, IPrintBothSidesTask, IPrintTask, IScanTask
    {
        public HPLaserPrinter(string brand, string color) : base(brand, color)
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

        public void PrintBothSides(Content content)
        {
            Console.WriteLine($"Printing both sides {content}");
        }
    }
}
