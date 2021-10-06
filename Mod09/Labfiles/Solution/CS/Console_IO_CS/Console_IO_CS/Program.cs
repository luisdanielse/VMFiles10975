using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_IO_CS
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

            char response;

            response = Convert.ToChar(Console.Read());

        }
    }
}
