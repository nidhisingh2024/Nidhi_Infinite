using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class String2

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to change");

            string inputStr = Console.ReadLine();

            if (inputStr.Length >= 2)
            {
                char firstWord = inputStr[0];
                char lastWord = inputStr[inputStr.Length - 1];
                string finalStr = lastWord + inputStr.Substring(1, inputStr.Length - 2) + firstWord;
                Console.WriteLine("Final String is" + " " + finalStr);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Inorder to change string it must contain two charcters");
            }
        }
    }
}