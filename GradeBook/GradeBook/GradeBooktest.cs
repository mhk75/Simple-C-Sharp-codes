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
            GradeBook myGradeBook = new GradeBook("Introduction to C# programming");
            myGradeBook.DisplayMessage();
            myGradeBook.DetermineClassAverage();
        }
    }
}
