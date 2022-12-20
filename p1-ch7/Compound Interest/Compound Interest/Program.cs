using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal principal = 1000;
            double yield = 0.05;
            decimal depositAmount = 0;
            for (int i = 1; i <= 10; i++)
            {
                depositAmount = principal * (decimal)Math.Pow((1 + yield), i);
                Console.WriteLine("{0}th year deposit is: {1:C}", i, depositAmount);
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            //int counter = 1;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //} while (counter <= 10);

        }
    }
}
