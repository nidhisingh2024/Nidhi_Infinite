using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3

{
    // Using delegate 
    delegate int CalculatorDelegate(int a, int b);

    class Calculator
    {
        // For Addition
        static int Add(int a, int b)
        {
            return a + b;
        }

        // For Subtraction
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        // For Multiplication
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        // For Division
        static int Divide(int a, int b)
        {
            return a / b;
        }

        static void Main()
        {
            // Creating delegate instance to use them
            CalculatorDelegate addition = Add;
            CalculatorDelegate subtraction = Subtract;
            CalculatorDelegate multiplication = Multiply;
            CalculatorDelegate  Division = Divide;

            // Enter both values to calculate
        

            Console.WriteLine("Enter first integer:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer:");
            int b = Convert.ToInt32(Console.ReadLine());

            // Performing arithmetic operations using delegates
            int additionResult = Add(a, b);
            int subtractionResult = Subtract(a, b);
            int multiplicationResult = Multiply(a, b);
            int divisionResult = Divide(a, b);

            // Results of Operations
            Console.WriteLine($"Result of addition: {additionResult}");
            Console.WriteLine($"Result of subtraction: {subtractionResult}");
            Console.WriteLine($"Result of multiplication: {multiplicationResult}");
            Console.WriteLine($"Result of division: {divisionResult}");
            Console.ReadLine();

        }

    }
}
