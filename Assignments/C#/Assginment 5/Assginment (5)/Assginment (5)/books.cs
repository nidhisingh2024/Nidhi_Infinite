
using System;
using System.Collections.Generic;

namespace BookLibrary
{
    public class Book
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Book(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book Name: {BookName}, Author: {AuthorName}");
            Console.Read();
        }
    }

    public class BookShelf
    {
        private List<Book> books = new List<Book>();

        public Book this[int index]
        {
            get { return books[index]; }
            set { books.Insert(index, value); }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books on the Bookshelf:");
            foreach (var book in books)
            {
                book.Display();
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the BookShelf class and assign values using the indexer
            var bookShelf = new BookShelf();
            string bName, aName;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the {i + 1} Book Name : ");
                bName = Console.ReadLine();
                Console.Write($"Enter The Author Name: ");
                aName = Console.ReadLine();
                bookShelf[i] = new Book(bName, aName);
                Console.WriteLine();

            }
            for(int i = 0; i < 5; i++)
            {
                bookShelf.DisplayBooks();
            }

            Console.WriteLine();


            // Displaying the books
            bookShelf.DisplayBooks();
            Console.ReadKey();
        }
    }
}



