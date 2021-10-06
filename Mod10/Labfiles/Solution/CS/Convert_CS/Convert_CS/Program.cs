using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] myArray = new Object[3];
            int myInt = 5;
            string myString = "Hello";
            char myChar = 'A';

            myArray[0] = myInt;
            myArray[1] = myString;
            myArray[2] = myChar;

            double myDouble;
            myDouble = myInt;
            myInt = (int)myDouble;

            myInt = (int)myArray[0];
            myString = (string)myArray[1];
            myChar = (char)myArray[2];

        }
    }
}
