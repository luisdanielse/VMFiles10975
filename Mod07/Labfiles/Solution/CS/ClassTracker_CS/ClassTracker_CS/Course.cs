using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTracker_CS
{
    class Course
    {
        private string courseTitle;
        private int creditHours;
        private string program;

        public string CourseTitle
        {
            get { return courseTitle; }
            set { courseTitle = value; }
        }

        public int CreditHours
        {
            get { return creditHours; }
            set { creditHours = value; }
        }

        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public void EnrollStudent(string studentName)
        {

        }

        public virtual float CalculateAverage(float[] arrGrades)
        {
            float avg = 0;

            return avg;
        }
    }
}
