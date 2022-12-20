using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismCaseStudy
{
    class BasePlusCommissionEmployee: CommissionEmployee
    {
        private decimal baseSalary;

        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary) :base(first, last, ssn, sales, rate)
        {
            baseSalary = salary;
        }

        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }

            set
            {
                if (value > 0)
                {
                    baseSalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("baseSalary", value, "baseSalary must be greater than zero");
                }
            }
        }

        public override decimal Earning()
        {
            return base.Earning() + BaseSalary;
        }

        public override string ToString()
        {
            return string.Format("base-salaried {0}; base salary: {1:c}",base.ToString(),BaseSalary);
        }
    }
}
