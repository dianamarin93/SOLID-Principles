using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            BrotherBusinessPrinter bp = new BrotherBusinessPrinter("Brother", "white");
            bp.PrintBothSides(Content.Banner);
            bp.Copy(Content.Pictures);

            EpsonJetPrinter eps = new EpsonJetPrinter("Epson", "grey");
            eps.Print(Content.Text);

            CanonMultiFunctionPrinter cmp = new CanonMultiFunctionPrinter("Canon", "black");
            cmp.Scan(Content.Pictures);
            Console.ReadKey();
        }
    }
}
