using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo_CS
{
    class Student : Person
    {
        private string school;
        private string program;

        public string School
        {
            get { return school; }
            set { school = value; }
        }
        
        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public void sleep()
        {

        }

        public void study()
        {

        }

        public override void move()
        {
            Console.WriteLine("Moving");
        }

       
    }
}
