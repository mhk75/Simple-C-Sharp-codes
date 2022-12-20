using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfChance
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Random random = new Random();
        //    int face1;
        //    int face2;
        //    int sum;
        //    face1 = random.Next(1, 7);
        //    face2 = random.Next(1, 7);
        //    sum = face1 + face2;
        //    switch (sum)
        //    {
        //        case 2:
        //            Console.WriteLine("You Lost this match\n2 int first throw");
        //            break;
        //        case 3:
        //            Console.WriteLine("You Lost this match\n3 int first throw");
        //            break;
        //        case 4:
        //            Console.WriteLine("Your Point is 4");
        //            break;
        //        case 5:
        //            Console.WriteLine("Your Point is 5");
        //            break;
        //        case 6:
        //            Console.WriteLine("Your Point is 6");
        //            break;
        //        case 7:
        //            Console.WriteLine("You Won this match\n7 int first throw");
        //            break;
        //        case 8:
        //            Console.WriteLine("Your Point is 8");
        //            break;
        //        case 9:
        //            Console.WriteLine("Your Point is 9");
        //            break;
        //        case 10:
        //            Console.WriteLine("Your Point is 10");
        //            break;
        //        case 11:
        //            Console.WriteLine("You Won this match\n11 int first throw");    
        //            break;
        //        case 12:
        //            Console.WriteLine("You Lost this match\n12 int first throw");
        //            break;
        //    }
        //    if (sum == 2 || sum == 3 || sum == 7 || sum == 12 || sum == 11)
        //        return;
        //    int point = sum;
        //    while (true)
        //    {
        //        face1 = random.Next(1, 7);
        //        face2 = random.Next(1, 7);
        //        sum = face1 + face2;
        //        if(sum == 7)
        //        {
        //            Console.WriteLine("You Lost this match\n7 before point");
        //            break;
        //        }
        //        if(sum == point)
        //        {
        //            Console.WriteLine("You Won this match\nyou have reached yout point");
        //            break;
        //        }
        //    }
        //}


        private static Random randomNumbers = new Random();
        private enum Status { CONTINUE,WON,LOST}
        private enum DiceNames
        {
            SNAKE_EYES = 2,
            TREY = 3,
            SEVEN = 4,
            YO_LEVEN = 11,
            BOX_CARS = 12
        }
        static void Main(string[] args)
        {
            Status gameStatus = Status.CONTINUE;

        }
           
        
    }
}
