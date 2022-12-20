using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        const int arrayLength = 10;
        static void Main(string[] args)
        {
            int[] myarray = new int[arrayLength];
            StudentsAndCafeTeria();
        }

        private static void SumArratElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("please enter Number:");
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine(sum);
        }

        private static void StudentsAndCafeTeria()
        {
            const int studentsNumber = 20;
            Random random = new Random();
            int[] ratings = new int[6];
            for (int rate = 0; rate < studentsNumber; rate++)
                ++ratings[random.Next(1,6)];
            Console.WriteLine("{0} {1,10}","rate","frequency");
            for (int rate = 1; rate < ratings.Length; rate++)
            {
                Console.WriteLine("{0,4} {1,10}",rate,ratings[rate]);
            }
        }
    }
}
