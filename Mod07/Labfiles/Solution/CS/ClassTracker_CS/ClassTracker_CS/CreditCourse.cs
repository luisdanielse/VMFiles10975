using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTracker_CS
{
    class CreditCourse : Course
    {

        public CreditCourse()
        {
            this.CourseTitle = "";
            this.CreditHours = 0;
            this.Program = "";
        }

        public CreditCourse(string title, int credits, string program)
        {
            this.CourseTitle = title;
            this.CreditHours = credits;
            this.Program = program;
        }

        public override float CalculateAverage(float[] arrGrades)
        {
            float avg = 0;
            float sum = 0;
            int numGrades = arrGrades.Count();

            foreach(float grade in arrGrades)
            {
                sum = sum + grade;
            }

            avg = sum / numGrades;

            return avg;
        }

        public float CalculateGPA(float grade)
        {
            char letterGrade;
            float gradePoints = 0.0F;

            if(grade >= 90)
            {
                letterGrade = 'A';
            }
            else if(grade >= 80 && grade <= 89)
            {
                letterGrade = 'B';
            }
            else if(grade >= 70 && grade <= 79)
            {
                letterGrade = 'C';
            }
            else if(grade >= 66 && grade <= 69)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            switch (letterGrade)
            {
                case 'A':
                    gradePoints = 4.0F;
                    break;

                case 'B':
                    gradePoints = 3.0F;
                    break;

                case 'C':
                    gradePoints = 2.0F;
                    break;

                case 'D':
                    gradePoints = 1.0F;
                    break;
            }

            return gradePoints;
        }
    }
}
