using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.Services
{
    public class ContractService
    {
        
        public void MakeContract(Person person)
        {
            Console.WriteLine($"Creating new contract for {person.FirstName} {person.LastName}!");
        }
}
}
