using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 7, 2, 30 };

            var query = numbers
                .Select(number => new { Number = number, Square = number * number })
                .Where(result => result.Square > 20);

            foreach (var result in query)
            {
                Console.WriteLine("Number: {0}, Square: {1}", result.Number, result.Square);
            }

            Console.Read();
        }
