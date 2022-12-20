using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeBook
    {
        private String courseName;
        
        public GradeBook(String name)
        {
            CourseName = name;
        }

        public GradeBook()
        {

        }
        
        public String CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }

        public void DisplayMessage(String nameofCourse)
        {
            Console.WriteLine("Welcome to the Grade Book for\n{0}", nameofCourse);
        }
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Grade Book for\n{0}", CourseName);
        }
    }
}
