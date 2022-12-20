using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}! = {1}",i,Factoriel(i));
            }
        }

        private static long Factoriel(int Number)
        {
            if (Number <= 1)
                return 1;
            else
                return Number * Factoriel(Number - 1);
        }
    }
}
