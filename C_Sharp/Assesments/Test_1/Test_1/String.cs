using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string you want to change");
            String inputStr = Console.ReadLine();
            Console.WriteLine("Enter the position you want to delete");
            int pos = int.Parse(Console.ReadLine());
            if (pos >= 0 && pos < inputStr.Length)
            {
                inputStr = inputStr.Remove(pos, 1);
                Console.WriteLine("The finale string is" + " " + inputStr);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Inavlid");
            }
        }
    }
}
