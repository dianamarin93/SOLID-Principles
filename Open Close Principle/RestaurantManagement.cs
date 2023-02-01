using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open_Close_Principle.Models;

namespace Open_Close_Principle
{
    class RestaurantManagement
    {
        // this method should call any employee to do his job

        public void CallEmployee(Employees employee)
        {
          employee.PerformDuties();
        }

    }
}
