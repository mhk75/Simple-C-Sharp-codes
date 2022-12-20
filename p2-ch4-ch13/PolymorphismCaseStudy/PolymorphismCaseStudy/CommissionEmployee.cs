using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismCaseStudy
{
    class CommissionEmployee : Employee
    {
        private decimal grossSales;
        private decimal commissionRate;

        public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate) :base(first, last, ssn)
        {
            commissionRate = rate;
            grossSales = sales;
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
                    throw new ArgumentOutOfRangeException("GrossSales", value, "sales must be >= 0");
                }
            }
        }
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value > 0 && value < 1)
                {
                    commissionRate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("CommissionRate", value, "rate must be > 0 and < 1 ");
                }
            }
        }

        public override decimal Earning()
        {
            return GrossSales * CommissionRate;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} \n {2}: {3:c0}\n{4}: {5:F2} ", "Commission Employee", base.ToString(), "gross Sales", GrossSales, "commission rate", CommissionRate);
        }
    }
}
