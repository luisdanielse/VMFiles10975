using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_Demo_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StringReader

            string stringToRead = "This is a plain text string";
            StringReader sr = new StringReader(stringToRead);

            string input = sr.ReadToEnd();
            Console.WriteLine(input);

            #endregion


            #region Reading Text Files

            //try
            //{
            //    // reader1 uses the close method to close the file after reading it
            //    // you should always release your file resources by issuing the close statement
            //    StreamReader reader1 = new StreamReader(@"C:\Users\username\documents\TextFile.txt");
            //    string contents = reader1.ReadToEnd();
            //    reader1.Close();
            //    Console.WriteLine(contents);
            //}
            //catch (Exception e)
            //{
            //    // Let the user know what went wrong.
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region Writing Text Files

            //string textToWrite = "This is text that will be written to a new text file";
            //try
            //{
            //    StreamWriter writer1 = new StreamWriter(@"C:\Users\username\Documents\NewTextFile.txt");
            //    writer1.Write(textToWrite);
            //    writer1.Close();
            //}
            //catch (Exception e)
            //{
            //    // Let the user know what went wrong.
            //    Console.WriteLine("The file could not not be written:");
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region Appending Text

            //string moreText = "We will add this line of text to an existing file.";
            //try
            //{
            //    StreamWriter writer1 = File.AppendText(@"C:\Users\username\Documents\NewTextFile.txt");
            //    writer1.WriteLine();
            //    writer1.WriteLine(moreText);
            //    writer1.Close();
            //}
            //catch (Exception e)
            //{
            //    // Let the user know what went wrong.
            //    Console.WriteLine("The file could not not be written:");
            //    Console.WriteLine(e.Message);
            //}

            #endregion

        }
    }
}
