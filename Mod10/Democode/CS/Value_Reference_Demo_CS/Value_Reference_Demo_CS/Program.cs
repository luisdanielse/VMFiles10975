using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Reference_Demo_CS
{
    class Program
    {
        struct NewPoint
        {
            public virtual void print()
            {
                Point newPoint = new Point();
                Object[] objArray = new Object[]{"one", 2, newPoint};

                try
                {
                    string newSTring = (string)objArray[0];
                    int newInt = (int)objArray[1];
                    Point aPoint = (Point)objArray[2];
                }
                catch (InvalidCastException castEx)
                {
                    Console.WriteLine("Cast failed, {0}", castEx.Message);
                }

            }

        }
        struct Point
        {
            int x;
            int y;
        }

        static void Main(string[] args)
        {

        }
    }
}
