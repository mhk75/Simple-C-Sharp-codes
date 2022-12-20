using System.Collections.Generic;
using System.Linq;
using System;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            items.Add("aQua");
            items.Add("RusT");
            items.Add("yElLeo");
            items.Add("rEd");

            var startswithR =
                from item in items
                let upperCaseString = item.ToUpper()
                where upperCaseString.StartsWith("R")
                select upperCaseString;

            foreach (var item in startswithR)
                Console.WriteLine("{0}",item);

            Console.WriteLine();

            items.Add("rUbY");
            items.Add("SaFfRon");

            foreach (var item in startswithR)
                Console.WriteLine("{0}",item);

        }
    }
}
