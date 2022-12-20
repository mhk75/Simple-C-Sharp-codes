using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismCaseStudy
{
    class HourlyEmployee: Employee
    {
        private decimal wage;
        private decimal hours;

        public HourlyEmployee(string first, string last, string ssn, decimal hoursWorked, decimal hourlyWage) : base(first, last, ssn)
        {
            wage = hourlyWage;
            hours = hourlyWage;
        }

        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value >= 0)
                {
                    wage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("wage", value, "wage must be >= 0");
                }
            }
        }

        public decimal Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0 && value <= 168)
                {
                    hours = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("hours", value, "hours must be >= 0 and <= 168 ");
                }
            }
        }

        public override decimal Earning()
        {
            if (hours < 40)
            {
                return Hours * Wage;
            }
            else
            {
                return (Hours * Wage) + ((Hours - 40) * Wage * 1.5M);
            }
        }

        public override string ToString()
        {
            return string.Format("salaried employee: {0}\n{1}: {2:c}; {3}: {4:F2}", base.ToString(), "hourly Wage", Wage, "hours worked", Hours);
        }
    }
}
