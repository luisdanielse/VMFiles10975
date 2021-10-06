using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student();
            newStudent.Age = 21;
            newStudent.eat();

            Instructor newInstructor = new Instructor();
            newInstructor.Height = 5.9F;
            newInstructor.move();

        }
    }
}
