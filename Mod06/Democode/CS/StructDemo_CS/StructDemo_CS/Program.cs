using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    public struct name
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string suffix;

        public name(string first, string middle, string last, string suff)
        {
            firstName = first;
            middleName = middle;
            lastName = last;
            suffix = suff;
        }

        public string getFullName()
        {
            return firstName + " " + middleName + " " + lastName + " " + suffix;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            name newName = new name();
            name newName2 = new name("Tom", "Green", "Thumb", "Jr.");

            newName.firstName = "Mark";
            newName.middleName = "";
            newName.lastName = "Twain";
            newName.suffix = "";

            Console.WriteLine(newName.firstName);
            Console.WriteLine(newName2.firstName);
        }
    }
}