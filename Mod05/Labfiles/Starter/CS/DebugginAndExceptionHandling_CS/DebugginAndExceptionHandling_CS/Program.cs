using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugginAndExceptionHandling_CS
{
    class Program
    {
        struct course
	    {
            public string courseName;
		    public int creditHours;
            public int gradePoints;
	    };

        static void Main(string[] args)
        {
            course[] courseList = PopulateTranscript();
            double GPA = GetGPA(courseList);
            Console.WriteLine("Your GPA is currently: " + GPA);
        }

        private static course[] PopulateTranscript()
        {
            course[] courseList = new course[5];

            for(int counter = 0; counter < courseList.Length; counter++)
            {
                course newCourse = new course();
                Console.WriteLine("Enter a course name");

                newCourse.courseName = Console.ReadLine();
                Console.WriteLine("Enter the credit hours for this course");

                newCourse.creditHours = Console.ReadLine();
                Console.WriteLine("Enter your grade points for this course");

                newCourse.gradePoints = Console.ReadLine();
                courseList[counter] = newCourse;
                
            }

            return courseList;
        }

        private static double GetGPA(course[] courseList)
        {
            double result = 0.0;
            int totalCredHours = 0;
            int totalGradePoints = 0;

            foreach(course currentCourse in courseList)
            {
                totalCredHours += currentCourse.creditHours;
                totalGradePoints += currentCourse.gradePoints;
            }

            result = totalGradePoints / totalCredHours;

            return result;
        }
    }
}
