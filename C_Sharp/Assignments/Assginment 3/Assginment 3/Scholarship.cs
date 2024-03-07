using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    using System;

    class Scholarship
    {
        public decimal Merit(int marks, decimal fees)
        {
            decimal scholarshipAmount = 0;

            // Calculate scholarship amount based on marks
            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2m * fees; // 20% of fees
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3m * fees; // 30% of fees
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5m * fees; // 50% of fees
            }

            return scholarshipAmount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter marks and fees
            Console.WriteLine("Enter marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fees:");
            decimal fees = Convert.ToDecimal(Console.ReadLine());

            // Create an instance of Scholarship class
            Scholarship scholarship = new Scholarship();

            // Call the Merit method to calculate scholarship amount
            decimal scholarshipAmount = scholarship.Merit(marks, fees);

            // Display the scholarship amount
            Console.WriteLine($"Scholarship amount: {scholarshipAmount}");
            Console.ReadLine();
        }
    }

}
