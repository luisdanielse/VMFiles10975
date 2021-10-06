using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_IO_Demo_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is using the Console.Write() method with a string.");
            Console.Write(" And this does the same, but is a separate call to show the text starting on the same line");
            // This call to Console.WriteLine() is intended to provide a blank line
            Console.WriteLine();

            Console.WriteLine("This is using the Console.WriteLine() method with a string.");
            Console.WriteLine(" And this does the same, but is a separate call to show the text starting on a new line");

            // declare a Boolean variable for output to the console window
            bool result = true;

            // show that this overload for WriteLine() will output the Boolean value
            Console.WriteLine(result);

            // Create a new Person object to pass to the WriteLine() method
            Person newPerson = new Person();
            Console.WriteLine(newPerson);

            // Read() and Readline() methods
            //char first;
            //char second;

            //first = Convert.ToChar(Console.Read());
            //second = Convert.ToChar(Console.Read());

            //Console.WriteLine("First: {0}, Second: {1}", first, second);

            //string input = Console.ReadLine();
            //Console.WriteLine(input);


        }
    }
}
