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
        private int[] grades = new int[10];
        public int Total { get; set; }
        public int Average { get; set; }
        public GradeBook(String name)
        {
            CourseName = name;
        }

        public GradeBook()
        {
        }

        public void DetermineClassAverage()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write("EnterGrade:");
                grades[i] = Convert.ToInt32(Console.ReadLine());
                Total += grades[i];
            }
            Average = Total / 10;
            Console.WriteLine("Total of all grades is {0}",Total);
            Console.WriteLine("Class average is {0}",Average);
        }

        public void DetermineClassAverage1()
        {
            int total;
            int gradecounter;
            int grade;
            double average;
            total = 0;
            gradecounter = 1;
            while (gradecounter <= 10)
            {
                Console.Write("EnterGrade:");
                grade = Convert.ToInt32(Console.ReadLine());
                Total += grade;
                gradecounter = gradecounter + 1;
            }
            average = Total / 10;
            Console.WriteLine("Total of all grades is {0}", total);
            Console.WriteLine("Class average is {0}", average);
        }

        public void DetermineClassAverage2()
        {
            int total;
            int gradecounter;
            int grade;
            double average;
            total = 0;
            gradecounter = 1;
            Console.Write("EnterGrade or -1 to quit:");
            grade = Convert.ToInt32(Console.ReadLine());
            while(grade != -1)
            {
                total += grade;
                gradecounter++;
                Console.Write("EnterGrade or -1 to quit:");
                grade = Convert.ToInt32(Console.ReadLine());
            }
            if (gradecounter != 0)
            {
                average = (double)total / gradecounter;
                Console.WriteLine("Total of all grades is {0}", total);
                Console.WriteLine("Class average is {0}", average);
            }
            else
            {
                Console.WriteLine("No grades were entered");
            }
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
