using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggerDemo_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 4, 5, 9, 1, 8, 3 };

           BubbleSort(myArray);

           Fibonacci(3);
        }

        static void BubbleSort(int[] myArray)
        {
            int temp = 0;

            for (int i = 1; i <= (myArray.Length - 1); i++)
            {
                for (int j = 0; j < (myArray.Length - 1); j++)
                {
                    if (myArray[j + 1] < myArray[j])
                    {
                        temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine();

            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }

            
        }

        static void Fibonacci(int numberOfValues)
        {
            int a = 0;
            int b = 1;
            int temp = 0;

            for(int counter =  0; counter < numberOfValues; counter++)
            {
                temp = a;
                a = b;
                b = temp + a;
                Console.WriteLine(a);
            }
        }
        
    }
}
