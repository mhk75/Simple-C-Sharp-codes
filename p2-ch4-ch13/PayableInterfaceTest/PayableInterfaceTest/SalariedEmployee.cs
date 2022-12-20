using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    public class SalariedEmployee: Employee
    {
        private decimal weeklySalary;
        public SalariedEmployee(string first, string last, string ssn, decimal salary) : base(first, last, ssn)
        {
            weeklySalary = salary;
        }

        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }

            set
            {
                if (value > 0)
                {
                    weeklySalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("weeklySalary", value, "weeklySalary must be greater than zero");
                }
            }
        }

        public override decimal GetPaymentAmount()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return string.Format("salaried employee: {0}\n{1}: {2:c}", base.ToString(), "weekly salary", WeeklySalary);
        }
    }
}
