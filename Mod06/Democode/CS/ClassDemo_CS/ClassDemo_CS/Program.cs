using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aStudent = new Person();

            aStudent._height = 5.5F;
            aStudent._gender = "male";
            aStudent.Walk();
            aStudent.Speak();

            Person newStudent = new Person(6.2F, 195.0F, "Caucasian", "female");
        }
    }

    public class Person
    {
        public float _height;
        public float _weight;
        public string _ethnicity;
        public string _gender;

        public Person()
        {
            _height = 5.7F;
            _weight = 198.6F;
            _ethnicity = "Doesnt matter";
            _gender = "male";
        }

        public Person(float height, float weight, string ethnicity, string gender)
        {
            _height = height;
            _weight = weight;
            _ethnicity = ethnicity;
            _gender = gender;
        }

        public void Walk()
        {

        }

        public void Run()
        {

        }

        public void Eat()
        {

        }

        public void Sit()
        {

        }

        public void Speak()
        {

        }

    }
}
