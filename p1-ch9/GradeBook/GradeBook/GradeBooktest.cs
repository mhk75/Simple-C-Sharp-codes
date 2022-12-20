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
            int[] gradesArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            GradeBook myGradeBook = new GradeBook("Introduction to C# programming",gradesArray);
            myGradeBook.DisplayMessage();
            myGradeBook.ProcessGrades();
        }
    }
}
