using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to create a:");

            Console.WriteLine();
            Console.WriteLine("S - Student");

            Console.WriteLine();
            Console.WriteLine("I - Instructor");

            Console.WriteLine();
            Console.WriteLine("Q - Quit");
            Console.WriteLine();

            char response;

            response = Convert.ToChar(Console.Read());

            switch (response)
            {
                case 's':
                case 'S':
                    CreateStudent();
                    break;

                case 'i':
                case 'I':
                    CreateInstructor();
                    break;

                case 'q':
                case 'Q':
                    Environment.Exit(0);
                    break;
            }
        }

        static void CreateStudent()
        {
            string first, last, gender;
            int age;

            Console.ReadLine();

            Console.WriteLine("Enter the student's first name.");
            first = Console.ReadLine();

            Console.WriteLine("Enter the student's last name.");
            last = Console.ReadLine();

            Console.WriteLine("Enter the student's gender.");
            gender = Console.ReadLine();

            Console.WriteLine("Enter the student's age.");
            age = Convert.ToInt32(Console.ReadLine());

            Student newStudent = new Student(first, last, gender, age);

            SaveToFile(newStudent);

        }

        static void CreateInstructor()
        {
            string first, last, gender;
            int age;

            Console.ReadLine();

            Console.WriteLine("Enter the instructor's first name.");
            first = Console.ReadLine();

            Console.WriteLine("Enter the instructor's last name.");
            last = Console.ReadLine();

            Console.WriteLine("Enter the instructor's gender.");
            gender = Console.ReadLine();

            Console.WriteLine("Enter the instructor's age.");
            age = Convert.ToInt32(Console.ReadLine());

            Instructor newInstructor = new Instructor(first, last, gender, age);

            SaveToFile(newInstructor);
        }

        static void SaveToFile(Person person)
        {
            string fileName;
            string header;

            if(person is Student)
            {
                fileName = "Students.txt";
                header = "Students";
                WriteContents(header, fileName, person);
            }
            else
            {
                fileName = "Instructors.txt";
                header = "Instructors";
                WriteContents(header, fileName, person);
            }

        }

        static void WriteContents(string header, string fileName, Person person)
        {
            if (!File.Exists(fileName))
            {
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine(header);
                writer.Write(person.FirstName + ", ");
                writer.Write(person.LastName + ", ");
                writer.Write(person.Gender + ", ");
                writer.Write(person.Age);
                writer.Close();
            }
            else
            {
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine();
                writer.WriteLine("{0}, {1}, {2}, {3}", person.FirstName, person.LastName, person.Gender, person.Age);
                writer.Close();
            }

            ReadFile(fileName);
        }

        static void ReadFile(string fileName)
        {
            Console.WriteLine("The file was saved with the following content:");
            StreamReader reader = new StreamReader(fileName);
            Console.WriteLine();
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
