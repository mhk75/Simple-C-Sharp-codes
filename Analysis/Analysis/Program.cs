using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int passes = 0;
            int failures = 0;
            int studentCounter = 1;
            int result = 0;

            while (studentCounter <= 10)
            {
                Console.Write("Enter result(1 = pass, 2 = fail):");
                result = Convert.ToInt32(Console.ReadLine());
                if (result == 1)
                    passes++;
                else
                    failures++;
                studentCounter++;
            }

            Console.WriteLine("Passed: {0}\nFailed: {1}",passes,failures);

            if(passes>8)
                Console.WriteLine("Bonous to instructor!");
        }
    }
}
