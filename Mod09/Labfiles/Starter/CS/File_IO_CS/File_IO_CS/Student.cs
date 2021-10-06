using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_CS
{
    class Student : Person
    {
        public Student(string first, string last, string gender, int age)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Gender = gender;
            this.Age = age;
        }

        public override void move()
        {

        }
    }
}
