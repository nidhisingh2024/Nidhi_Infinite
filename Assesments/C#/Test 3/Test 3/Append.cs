using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_3
{
    class Append
    {
        static void Main(string[] args)
        {
            string fileName = "example.txt";
            string textToAppend = "New text :";

            try
            {
                // To check if the file exist o not
                if (!File.Exists(fileName))
                {
                    // If not create a new file
                    using (StreamWriter sw = File.CreateText(fileName))
                    {
                        sw.WriteLine(textToAppend);
                    }
                }
                else
                {
                    // If exist append text
                    using (StreamWriter sw = File.AppendText(fileName))
                    {
                        sw.WriteLine(textToAppend);
                    }
                }

                Console.WriteLine("Your text appended in a file sucessfully:");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred:  + not found");
               
            }
            Console.ReadLine();
        }
    }
}


