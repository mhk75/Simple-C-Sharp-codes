using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeBook
    {
        private int acounter;
        private int bcounter;
        private int ccounter;
        private int dcounter;
        private int fcounter;
        int gradecounter;
        int grade;
        private String courseName;
        private int[] grades = new int[10];
        public int Total { get; set; }
        double Average { get; set; }
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
            Total = 0;
            gradecounter = 1;
            while (gradecounter <= 10)
            {
                Console.Write("EnterGrade:");
                grade = Convert.ToInt32(Console.ReadLine());
                Total += grade;
                gradecounter = gradecounter + 1;
            }
            Average = Total / 10;
            Console.WriteLine("Total of all grades is {0}", Total);
            Console.WriteLine("Class average is {0}", Average);
        }

        public void DetermineClassAverage2()
        {
            Total = 0;
            gradecounter = 1;
            Console.Write("EnterGrade or -1 to quit:");
            grade = Convert.ToInt32(Console.ReadLine());
            while(grade != -1)
            {
                Total += grade;
                gradecounter++;
                Console.Write("EnterGrade or -1 to quit:");
                grade = Convert.ToInt32(Console.ReadLine());
            }
            if (gradecounter != 0)
            {
                Average = (double)Total / gradecounter;
                Console.WriteLine("Total of all grades is {0}", Total);
                Console.WriteLine("Class average is {0}", Average);
            }
            else
            {
                Console.WriteLine("No grades were entered");
            }
        }

        public void DetermineClassAverage3()
        {
            Total = 0;
            gradecounter = 0;
            Console.WriteLine("Enter integer grades in range 0-100");
            Console.WriteLine("type <ctrl> z and press enter to terminate input");
            string input= Console.ReadLine();
            while (input != null)
            {
                grade = Convert.ToInt32(input);
                Total += grade;
                gradecounter++;
                Checkdata(grade);
                input = Console.ReadLine();
            }
            Average = Total / gradecounter;
        }

        private void Checkdata(int grade)
        {
            switch (grade/10)
            {
                case 9:
                    acounter++;
                    break;
                case 8:
                    bcounter++;
                    break;
                case 7:
                    ccounter++;
                    break;
                case 6:
                    dcounter++;
                    break;
                default:
                    fcounter++;
                    break;
            }
        }

        public void ReportData()
        {
            Console.WriteLine("Grade Report:");
            Console.WriteLine("Total of {0} grades entered is {1}",gradecounter,Total);
            Console.WriteLine("Class Average is {0}",Average);
            Console.WriteLine("Number of students who received each grade:");
            Console.WriteLine("A:{0}",acounter);
            Console.WriteLine("B:{0}",bcounter);
            Console.WriteLine("C:{0}",ccounter);
            Console.WriteLine("D:{0}",dcounter);
            Console.WriteLine("F:{0}",fcounter);
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
