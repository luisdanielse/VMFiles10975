using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericVariables_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int courseID;
            int lengthInWeeks;
            double myGPA;
            string courseTitle;
            string courseDescription;
            string instructorName;
            bool doesExist;
            bool passingGrade;
            bool isEnrolled;

            courseID = 101;
            lengthInWeeks = 10;
            myGPA = 0.0;

            Console.Out.WriteLine(courseID);
            Console.Out.WriteLine(lengthInWeeks);
            Console.Out.WriteLine(myGPA);

            courseTitle = "CS101";
            courseDescription = "This course teaches introductory programming topics";
            instructorName = "MCT Instructor";

            Console.Out.WriteLine(courseTitle);
            Console.Out.WriteLine(courseDescription);
            Console.Out.WriteLine(instructorName);

            doesExist = true;
            passingGrade = true;
            isEnrolled = false;

            Console.Out.WriteLine(doesExist);
            Console.Out.WriteLine(passingGrade);
            Console.Out.WriteLine(isEnrolled);
            Console.ReadKey();
        }
    }
}
