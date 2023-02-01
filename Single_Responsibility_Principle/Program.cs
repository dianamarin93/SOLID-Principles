using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Single_Responsibility_Principle.CustomExceptions;

namespace Single_Responsibility_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResources hr = new HumanResources(7000,
                new List<Person>()
                {
                    new Person("Diana", "Marin", 6500, "software engineer") ,
                    new Person("Andrei", "Badea", 9000, "arhitect engineer"),
                    new Person("Andreea", "Marin", 3400, "it recruiter")
                }
                , new List<string>()
                {
                    "software engineer",
                    "arhitect engineer",
                    "hr recruiter"
                });

            try
            {
                hr.Hire();
            }
            catch (JobNotAvailableException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotDesiredSalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
}
