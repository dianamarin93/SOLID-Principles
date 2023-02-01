using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close_Principle
{
    public class Chef : Employees
    {
        public Chef(string firstName, string lastName, string department) : base(firstName, lastName, department)
        {
        }

        private void Cook()
        {
            Console.WriteLine("Cooking for the customers!");
        }

        private void DesignPlates()
        {
            Console.WriteLine("Designing the plates!");
        }

        private void CutMeatChops()
        {
            Console.WriteLine("Cutting the meat chops!");
        }

        public override void PerformDuties()
        {
            Cook();
            DesignPlates();
            CutMeatChops();
        }
    }
}
