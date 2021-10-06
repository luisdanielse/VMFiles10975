using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataStructures_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array here called grdsArray
            float[] grdsArray = new float[5];


            // Call the addGrades method, passing it the grdsArray
            addGrades(grdsArray);


            // After adding grades to the array, call the displayGrades method
            // to print out the grades to the console window
            // Use the foreach construct to iterate over the array
            displayGrades(grdsArray);

            // Create a new Stack object called myStack
            Stack myStack = new Stack();



            // Call the pushStack() method passing in the grades array for values
            pushStack(grdsArray, myStack);
            


            // Call the popStack() method twice to remove the top two items from stack
            // The popStack method will display each popped item to the console window
            popStack(myStack);
            popStack(myStack);


            // Create a new SortedList object called myCourses
            SortedList myCourses = new SortedList();



            // Call the populateList() method
            populateList(myCourses);


            // display a course in the list by passing a key
            displayList(myCourses, "CS101");



            // Remove an item from the myCourses list using the key
            removeListItem(myCourses, "CS201");

        }

        static void addGrades(float[] grdArray)
        {
            grdArray[0] = 98;
            grdArray[1] = 99;
            grdArray[2] = 89;
            grdArray[3] = 95;
            grdArray[4] = 96;
        }

        static void displayGrades(float[] grdArray)
        {
            foreach (double item in grdArray)
            {
                Console.WriteLine(item);
            }
        }

        static void pushStack(float[] grdArray, Stack stack)
        {
            foreach(float item in grdArray)
            {
                stack.Push(item);
            }
        }

        // pop the top item from the stack object passed in
        // and write the value out to the console window
        static void popStack(Stack stack)
        {
            Console.WriteLine("Item removed from the stack: ");
            float item = (float) stack.Pop();
            Console.WriteLine(item);
        }

        static void populateList(SortedList list)
        {
            list.Add("CS101", "Introduction to Computer Science");
            list.Add("CS102", "Data Structures and Algorithm Analysis");
            list.Add("CS201", "Introduction to Databases");
            list.Add("CS301", "Introduction to Object-Oriented Programming");
        }

        static void displayList(SortedList list, string key)
        {
            int index;
            string course;
            index = list.IndexOfKey(key);
            course = (string)list.GetByIndex(index);
            Console.WriteLine(course);
        }

        static void removeListItem(SortedList list, string key)
        {
            int index;
            string course;
            index = list.IndexOfKey(key);
            course = (string) list.GetByIndex(index);
            list.Remove(key);
            Console.WriteLine(course + " was removed from the list.");
        }
    }
}
