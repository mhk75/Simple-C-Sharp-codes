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
        private int[] frequency = new int[11];
        public int Total { get; set; }
        double Average { get; set; }
        public GradeBook(String name)
        {
            CourseName = name;
        }

        public GradeBook()
        {
        }

        public GradeBook(string name,int[] array)
        {
            grades = array;
            CourseName = name;
        }

        public void ProcessGrades()
        {
            ShowGrades();
            DetermineClassAverageForReceivedData(grades);
            Calculatemaximum();
            Calculateminimum();
            Console.WriteLine();
            Checkdata(grades);
            DisplayChart(frequency);
        }

        public void ShowGrades()
        {
            Console.WriteLine("The Grades Are:\n");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Student {0,2}: {1,3}",i+1,grades[i]);
            }
            Console.WriteLine();
        }

        public void Calculatemaximum()
        {
            int max = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (max < grades[i])
                    max = grades[i];
            }
            Console.WriteLine("Highest Grade is: {0}",max);
        }

        public void Calculateminimum()
        {
            int min = int.MaxValue;
            for (int i = 0; i < grades.Length; i++)
            {
                if (min > grades[i])
                    min = grades[i];
            }
            Console.WriteLine("Lowest Grade is: {0}", min);
        }

        public void DetermineClassAverageForReceivedData(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Total += grades[i];
            }
            Average = Total / array.Length;
            Console.WriteLine("Total of all grades is {0}", Total);
            Console.WriteLine("Class average is {0}", Average);
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

        private void Checkdata(int[] gradearray)
        {
            for (int i = 0; i < gradearray.Length; i++)
            {

                switch (gradearray[i] / 10)
                {
                    case 10:
                        frequency[10]++;
                        break;
                    case 9:
                        frequency[9]++;
                        break;
                    case 8:
                        frequency[8]++;
                        break;
                    case 7:
                        frequency[7]++;
                        break;
                    case 6:
                        frequency[6]++;
                        break;
                    case 5:
                        frequency[5]++;
                        break;
                    case 4:
                        frequency[4]++;
                        break;
                    case 3:
                        frequency[3]++;
                        break;
                    case 2:
                        frequency[2]++;
                        break;
                    case 1:
                        frequency[1]++;
                        break;
                    default:
                        frequency[0]++;
                        break;
                }
            }
        }

        public void ReportDataDistribution()
        {
            Console.WriteLine("Grade Distribution:");
            Console.WriteLine("A:{0}", acounter);
            Console.WriteLine("B:{0}", bcounter);
            Console.WriteLine("C:{0}", ccounter);
            Console.WriteLine("D:{0}", dcounter);
            Console.WriteLine("F:{0}", fcounter);
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
            Console.WriteLine("Welcome to the Grade Book for\n{0}\n", nameofCourse);
        }
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Grade Book for\n{0}\n", CourseName);
        }

        public void DisplayChart(int[] array)
        {
            Console.WriteLine("Grade Distribution:");
            
            for (int i = 0; i < array.Length; i++)
            {
                if(i == 10)
                    Console.Write("  100: ");
                else
                    Console.Write("{0:D2}-{1:D2}: ",i*10,i*10+9);
                for (int j = 0; j < array[i]; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

    }
}
