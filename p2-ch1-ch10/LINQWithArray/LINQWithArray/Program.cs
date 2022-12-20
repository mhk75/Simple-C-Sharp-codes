using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            Console.Write("Original Array:");
            foreach (var item in values)
                Console.Write(" {0}",item);
            Console.WriteLine();

            var filtered = from value in values
                           where value > 4
                           select value;

            Console.Write("Elements With Values Greater Than 4:");
            foreach (var item in filtered)
                Console.Write(" {0}", item);
            Console.WriteLine();

            var sorted = from value in values
                         orderby value
                         select value;

            Console.Write("Sorted Array Elements:");
            foreach (var item in sorted)
                Console.Write(" {0}", item);
            Console.WriteLine();

            var sortFilteredResults = from value in filtered
                                      orderby value descending
                                      select value;

            Console.Write("Elements With Values Greater Than 4,Sorted descending (seperated):");
            foreach (var item in sortFilteredResults)
                Console.Write(" {0}", item);
            Console.WriteLine();

            var sortedAndFiltered = from value in values
                                    where value < 4
                                    orderby value descending
                                    select value;

            Console.Write("Elements With Values Greater Than 4,Sorted descending (one query) :");
            foreach (var item in sortFilteredResults)
                Console.Write(" {0}", item);
            Console.WriteLine();
        }
    }
}
