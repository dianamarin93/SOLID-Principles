using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example2
{
    class Factory
    {
        public static LogService CreateLogger()
            => new LogService();

        public static EmailService CreateEmailer()
            => new EmailService();

        public static Employee CreateEmployee(string firstName, string lastName, string emailAddress, string phoneNumber)
            => new Employee(firstName, lastName, emailAddress, phoneNumber);

        public static Task CreateTask(string taskName, IEmployee owner)
            => new Task(taskName, owner);
    }
}
