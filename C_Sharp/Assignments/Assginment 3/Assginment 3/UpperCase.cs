using System;

namespace UpperCase
{


    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their first name and store it in a variable
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            // Prompt the user to enter their last name and store it in a variable
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            // Call the Display method to show the names in uppercase
            Display(firstName, lastName);
        }

        // Static method to display the names in uppercase
        static void Display(string firstName, string lastName)
        {
            // Convert the first name to uppercase and display it
            Console.WriteLine("Uppercase first name:");
            Console.WriteLine(firstName.ToUpper());
            Console.ReadLine();

            // Convert the last name to uppercase and display it
            Console.WriteLine("Uppercase last name:");
            Console.WriteLine(lastName.ToUpper());
            Console.ReadLine();
        }
    }
}