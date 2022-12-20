using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComissionEmployee
{
    public class BasePlusComissionEmployee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;
        private decimal comissionRate;
        private decimal baseSalary;

        public BasePlusComissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
        {
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            grossSales = sales;
            comissionRate = rate;
            baseSalary = salary;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
        }

        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value >= 0)
                {
                    grossSales = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("GrossSales", value, "GrossSales must be >= 0");
                }
            }
        }

        public decimal ComissionRate
        {
            get
            {
                return comissionRate;
            }
            set
            {
                if (value > 0 && value < 0)
                {
                    comissionRate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("ComissionRate", value, "ComissionRate must be 0 < and < 1");
                }
            }
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

        public decimal Earnings()
        {
            return BaseSalary + (comissionRate * grossSales);
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
                "Comission employee", firstName, lastName,
                "Social Security Number", SocialSecurityNumber,
                "GrossSales", GrossSales,
                 "ComissionRate", ComissionRate,
                  "BaseSalary", BaseSalary);
        }
    }
}
