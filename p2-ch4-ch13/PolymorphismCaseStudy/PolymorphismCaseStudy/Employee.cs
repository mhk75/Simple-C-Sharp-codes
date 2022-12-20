using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismCaseStudy
{
    public abstract class Employee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;

        public Employee(string first, string last, string ssn)
        {
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n ssn: {3}", "EmployeeName", firstName, lastName, socialSecurityNumber);
        }

        public abstract decimal Earning();
    }
}
