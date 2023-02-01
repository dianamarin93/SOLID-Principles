using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    interface IFaxTask
    {
        void Fax(Content content);
    }
}
