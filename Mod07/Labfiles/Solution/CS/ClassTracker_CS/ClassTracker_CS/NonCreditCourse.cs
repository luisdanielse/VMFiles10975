using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTracker_CS
{
    class NonCreditCourse : Course
    {
        public char CalculateGrade(float grade)
        {
            char letterGrade;
            
            if (grade >= 90)
            {
                letterGrade = 'A';
            }
            else if (grade >= 80 && grade <= 89)
            {
                letterGrade = 'B';
            }
            else if (grade >= 70 && grade <= 79)
            {
                letterGrade = 'C';
            }
            else if (grade >= 66 && grade <= 69)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            return letterGrade;
        }
    }
}
