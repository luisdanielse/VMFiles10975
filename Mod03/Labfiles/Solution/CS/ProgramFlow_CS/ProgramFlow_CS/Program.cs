using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            SetInstructorName("John Smith");
            SetCourseTitle("CS 101");
            AddClass("CS 101", false, false, false);
            DisplayReminders("Wednesday");
            CalculateAverage();
            CalculateAverageWithWhile();
        }

        static void SetInstructorName(string newName)
        {
            string instructorName = newName;
            Console.Out.WriteLine("Instructor name is " + instructorName);
        }
        static void SetCourseTitle(string newTitle)
        {
            bool result = ValidateCourseTitleLength(newTitle);
            if (result)
            {
                string courseTitle = newTitle;
                Console.Out.WriteLine("Course title is " + courseTitle);
            }
            else
            {
                Console.Out.WriteLine("Class name exceeds 50 characters, please shorten.");
            }
        }

        static bool ValidateCourseTitleLength(string title)
        {
            if(title.Length <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void AddClass(string title, bool isInProgram, bool isRequired, bool isElective)
        {

            if(isInProgram)
            {
               if(isRequired)
               {
                  Console.Out.WriteLine(title + " is in the program and is a required course.");
               }
               else if(isElective)
               {
                  Console.Out.WriteLine(title + " is in the program and is an elective course.");
               }
               else
               {
                   Console.Out.WriteLine(title + " is in the program and is an extra credit course.");
               }
            }
            else
            {
                Console.Out.WriteLine(title + " is not in the Program.");
            }

        }

        static void DisplayReminders(string day)
        {
            
            switch (day)
            {
                case "Wednesday":
                    Console.Out.WriteLine("Discussion post is due today!");
                    break;
                case "Friday":
                    Console.Out.WriteLine("Quiz is due today!");
                    break;
                case "Sunday":
                    Console.Out.WriteLine("Assignment is due today!");
                    break;
                default:
                    Console.Out.WriteLine("Study new material, nothing due today.");
                    break;
            }

        }

        static void CalculateAverage()
        {
            double[] grades = new double[] { 89, 98, 99, 90, 95 };
            double average = 0.0;
            double total = 0.0;
            int gradeCounter;

            for (gradeCounter = 0; gradeCounter < grades.Length; gradeCounter++)
            {
                total = total + grades[gradeCounter];
            }

            average = total / gradeCounter;
            Console.Out.WriteLine("Grade average is " + average);
        }

        static void CalculateAverageWithWhile()
        {
            double grade = 0;
            double total = 0;
            double average = 0;
            int gradeCounter = 0;

            Console.Out.WriteLine("Enter first grade");
            grade = Double.Parse(Console.ReadLine());

            while(grade != 200)
            {
                total = total + grade;
                gradeCounter++;
                Console.Out.WriteLine("Enter another grade or enter 200 to end.");
                grade = Double.Parse(Console.ReadLine());
            }

            average = total / gradeCounter;
            Console.Out.WriteLine("Grade average is: " + average);

        }

    }
}
