using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three floating_point values,\npress 'enter' after each one");
            double x;
            double y;
            double z;
            double result;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
            result = MaximumFinder(x, y, z);
            Console.WriteLine("the maximum is:" + result);
        }

        private static double MaximumFinder(double x, double y, double z)
        {
            double maximum = x;

            if (maximum < y)
                maximum = y;
            if (maximum < z)
                maximum = z;
            return maximum;
        }

    }
}
