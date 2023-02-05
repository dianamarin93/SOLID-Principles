using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Example2
{
    class Task
    {
        public string TaskName { get; set; }
        public IEmployee Owner { get; set; }
        public double WorkedHours { get; private set; }
        public bool IsFinished { get; private set; }

        public Task(string taskName, IEmployee owner)
        {
            TaskName = taskName;
            Owner = owner;
        }

        public void Execute(double hours)
        {
            WorkedHours += hours;
            ILogger logService = Factory.CreateLogger();
            logService.Log($"Start working on {TaskName}");
        }

        public void CompleteTask()
        {
            IsFinished = true;

            ILogger logService = Factory.CreateLogger();
            logService.Log($"Completed work on {TaskName}");

            IEmailer email = Factory.CreateEmailer();
            email.SendEmail(Owner, $"The task, {TaskName} is complete!");
        }
    }
}
