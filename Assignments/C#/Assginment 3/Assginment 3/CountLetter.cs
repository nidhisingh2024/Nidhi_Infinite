using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetter

{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a string
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            // Prompt the user to enter the letter to be counted
            Console.WriteLine("Enter the letter to be counted:");
            char letter = Console.ReadLine()[0]; // Read the first character as the letter

            // Call the CountOccurrences method to count the occurrences of the letter
            int count = CountOccurrences(inputString, letter);

            // Display the result
            Console.WriteLine($"The letter '{letter}' appears {count} times in the string.");
            Console.ReadLine();
        }

        // Method to count the occurrences of a letter in a string
        static int CountOccurrences(string inputString, char letter)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                // Check if the current character matches the letter
                if (char.ToUpper(c) == char.ToUpper(letter))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
