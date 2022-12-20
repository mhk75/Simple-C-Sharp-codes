using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    public class Invoice : IPayable
    {
        private int quantity;
        private decimal pricePerItem;

        public string PartNumber { get; set; }
        public string PartDescription { get; set; }

        public Invoice( string part, string description, int count, decimal price)
        {
            PartNumber = part;
            PartDescription = description;
            quantity = count;
            pricePerItem = price;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Quantity", value, "Quantity must be >= 0");
                }
            }
        }
        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if (value >= 0)
                {
                    pricePerItem = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("PricePerItem", value, "PricePerItem must be >= 0");
                }
            }
        }

        public override string ToString()
        {
            return String.Format("{0} \n{1}: {2} ({3}) \n{4}: {5} \n{6}: {7:C}",
                "invoice", "part number", PartNumber, PartDescription,
                "quantity", Quantity, "price per item", PricePerItem);
        }

        public decimal GetPaymentAmount()
        {
            return Quantity * PricePerItem;
        }
    }
}
