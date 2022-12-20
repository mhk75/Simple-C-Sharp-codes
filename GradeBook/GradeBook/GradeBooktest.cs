using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBooktest
    {
        static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook();
            GradeBook gradeBook1 = new GradeBook("Introduction to C# programming");
            Console.WriteLine("initial course name is : '{0}'\n", gradeBook1.CourseName);
            Console.WriteLine("initial course name is : '{0}'\n",myGradeBook.CourseName);
            Console.WriteLine("please Enter the course name:");
            string nameofcourse = Console.ReadLine();
            Console.WriteLine();
            myGradeBook.DisplayMessage(nameofcourse);
        }
    }
}
