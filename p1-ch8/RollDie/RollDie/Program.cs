using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int frequency1 = 0;
            int frequency2 = 0;
            int frequency3 = 0;
            int frequency4 = 0;
            int frequency5 = 0;
            int frequency6 = 0;
            int face;

            for (int i = 0; i < 60000; i++)
            {
                face = random.Next(1, 7);
                switch (face)
                {
                    case 1:
                        frequency1++;
                        break;
                    case 2:
                        frequency2++;
                        break;
                    case 3:
                        frequency3++;
                        break;
                    case 4:
                        frequency4++;
                        break;
                    case 5:
                        frequency5++;
                        break;
                    default:
                        frequency6++;
                        break;
                }
            }

            Console.WriteLine("number of times 1 showed:{0}\nnumber of times 2 showed:{1}\nnumber of times 3 showed:{2}\nnumber of times 4 showed:{3}\nnumber of times 5 showed:{4}\nnumber of times 6 showed:{5}\n",
            frequency1,frequency2,frequency3,frequency4,frequency5,frequency6);
        }
    }
}
