using System;
using System.Collections.Generic;
using System.Linq;

namespace lambda
{
    class lambda2
    {
        static List<string> Words = new List<string>();

        public static void Main()
        {
            GetListWords();
            PrintWords();
        }

        public static void GetListWords()
        {
            Console.Write("Enter the size of the list -> ");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                string word;
                Console.Write($"Enter The {i + 1} Word -> ");
                word = Console.ReadLine().ToLower();
                Words.Add(word);
            }
        }

        public static void PrintWords()
        {
            var word = Words.Where(w => w.StartsWith("a") && w.EndsWith("m"));
            foreach (var wd in word)
            {
                Console.Write(wd + " ");
            }
            Console.Read();
        }
    }
}
