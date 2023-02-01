using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.CustomExceptions
{
    public class JobNotAvailableException : ApplicationException
    {
        private string message = "Sorry! The desired job is not available for the moment!";

        public override string Message => message;
        
    }
}
