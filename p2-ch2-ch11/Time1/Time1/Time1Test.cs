using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time1
{
    internal class Time1Test
    {
        static void Main(string[] args)
        {
            Time1 time = new Time1();

            Console.Write("the initial universal time is:");
            Console.WriteLine(time.ToUniversalString());
            Console.Write("the initial standard time is:");
            Console.WriteLine(time.ToString());
            Console.WriteLine();

            time.SetTime(13, 27, 6);

            Console.Write("universal time after SetTime is:");
            Console.WriteLine(time.ToUniversalString());
            Console.Write("standard time after SetTime is:");
            Console.WriteLine(time.ToString());
            Console.WriteLine();

            try
            {
                time.SetTime(99, 99, 99);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            Console.WriteLine("After attempting invalid settings:");
            Console.Write("universal time after SetTime is:");
            Console.WriteLine(time.ToUniversalString());
            Console.Write("standard time after SetTime is:");
            Console.WriteLine(time.ToString());
        }
    }
}
