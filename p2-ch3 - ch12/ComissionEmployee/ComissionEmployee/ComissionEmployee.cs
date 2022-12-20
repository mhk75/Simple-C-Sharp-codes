using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComissionEmployee
{
    public class ComissionEmployee: Object
    {
        protected string firstName;
        protected string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;
        private decimal comissionRate;

        public ComissionEmployee(string first,string last,string ssn,decimal sales,decimal rate)
        {
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            grossSales = sales;
            comissionRate = rate;
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
                if(value > 0 && value < 0)
                {
                    comissionRate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("ComissionRate", value, "ComissionRate must be 0 < and < 1");
                }
            }
        }

        public virtual decimal Earnings()
        {
            return comissionRate * grossSales;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
                "Comission employee", firstName, lastName,
                "Social Security Number", SocialSecurityNumber,
                "GrossSales", GrossSales,
                 "ComissionRate", ComissionRate);
        }
    }
}
