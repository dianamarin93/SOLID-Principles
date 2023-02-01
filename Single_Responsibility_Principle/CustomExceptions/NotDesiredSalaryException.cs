using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.CustomExceptions
{
    public class NotDesiredSalaryException : ApplicationException
    {
        private string message = "Sorry! But the desired salary is not related to our budget!";

        public override string Message => message;
    }
}
