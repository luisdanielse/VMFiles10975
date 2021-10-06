using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDemo_CS
{
    class Program
    {
        
        static void Main(string[] args)
        {

            #region Array Demo

            //// declaration of array, initialized with 10 elements.  Values are supplied
            //// memory set aside to hold ten integers 
            //int[] myArray = new int[] { 1, 4, 5, 6, 3, 10, 12, 500, 90, 1000 };

            //foreach (int element in myArray)
            //{
            //    Console.WriteLine(element);
            //}

            //Console.WriteLine();
            //Console.WriteLine("The element at index position 3 is: {0}", myArray[3]);
            //Console.WriteLine();

            //// Change the value at position 5 then print out the array again
            //myArray[4] = 50;

            //foreach (int element in myArray)
            //{
            //    Console.WriteLine(element);
            //}

            #endregion

            #region Stack Demo

            //int[] newArray = new int[] { };
            //Stack myStack = new Stack();
            //myStack.Push("Hello");
            //myStack.Push(2);
            //myStack.Push(newArray);
            //myStack.Push("This is on top");

            //Console.WriteLine(myStack.Peek());

            //myStack.Pop();

            //Console.WriteLine(myStack.Peek());
            
            #endregion

            #region SortedList Demo

            //SortedList sortList = new SortedList();
            //sortList.Add(2, "Number 2");
            //sortList.Add(3, "Number 3");
            //sortList.Add(1, "Number 1");

            //// output the text value for the key 2
            //Console.WriteLine("The value represented by the key '2' is: " + sortList.GetByIndex(1));

            #endregion

            #region Queue Demo

            //Queue myQueue = new Queue();
            //myQueue.Enqueue("First Item");
            //myQueue.Enqueue("Second Item");
            //myQueue.Enqueue("Third Item");
            //myQueue.Enqueue("Last Item");

            //Console.WriteLine("The queue contains: ");
            //foreach (string element in myQueue)
            //{
            //    Console.WriteLine(element);
            //}

            //Console.WriteLine();
            //Console.Write("The item at the beginning of the queue is: ");
            //Console.WriteLine(myQueue.Peek());
            //Console.WriteLine();

            //// check to see if an element exists called Third Item
            //bool exists = myQueue.Contains("Third Item");
            //Console.Write("Does the queue contain 'Third Item'? ");
            //Console.WriteLine(exists);
            //Console.WriteLine();

            //// Remove the first item and print out the new first item in the queue
            //myQueue.Dequeue();
            //Console.WriteLine("The item 'First Item' was removed using Dequeue and now the first item is: ");
            //Console.WriteLine(myQueue.Peek());
            //Console.WriteLine();

            #endregion

            #region Dictionary Demo

            //Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            //myDictionary.Add("Tree", "A perennial plant with an elongated stem, or trunk, supporting leaves or branches");
            //myDictionary.Add("One", "A text value used to represent the number 1.");
            //Console.WriteLine();

            #endregion

            #region SortedDictionary Demo

            //SortedDictionary<string, string> srtDictionary = new SortedDictionary<string, string>();
            //srtDictionary.Add("Tree", "A perennial plant with an elongated stem, or trunk, supporting leaves or branches");
            //srtDictionary.Add("One", "A text value used to represent the number 1.");
            //Console.WriteLine();

            #endregion
        }

    }
}
