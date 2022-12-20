using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComissionEmployee
{
    public class InheritedBasePlusComissionEmployee: ComissionEmployee
    {
        public decimal baseSalary;
        public InheritedBasePlusComissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
            : base(first, last, ssn, sales, rate)
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
                if (value >= 0)
                {
                    baseSalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >= 0");
                }
            }
        }

        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }

        public override string ToString()
        {
            return string.Format("base-salaried {0}\nbase salary: {1:C}",
                base.ToString(), BaseSalary);
        }

    }
}
