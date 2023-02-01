using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Single_Responsibility_Principle.CustomExceptions;
using Single_Responsibility_Principle.Services;

namespace Single_Responsibility_Principle
{
    class HumanResources
    {
        private ContractService cs = new ContractService();
        private LogService ls = new LogService();
        private EmailService es = new EmailService();
        public int Budget { get; set; }


        public List<Person> Applicants
        {
            get; set;
        }
        public List<string> AvailableJobs { get; set; }

        public HumanResources(int budget, List<Person> applicants, List<string> jobs)
        {
            Budget = budget;
            Applicants = applicants;
            AvailableJobs = jobs;
        }

        public void Hire()
        {
            foreach (var applicant in Applicants)
            {
                if (AvailableJobs.Contains(applicant.DesiredJob) && Budget > applicant.DesiredSalary)
                {
                    es.SendEmail(applicant);
                    ls.LogEmployee(applicant);
                    cs.MakeContract(applicant);
                }
                if (!AvailableJobs.Contains(applicant.DesiredJob))
                {
                    throw new JobNotAvailableException();
                }
                if (Budget < applicant.DesiredSalary)
                {
                    throw new NotDesiredSalaryException();
                }
            }
        }

    }
}
