using System;

namespace CSharpCodingChallenge
{
    internal class Day70_ArrayObjectSort
    {
        // Custom class type stored inside the array
        class Book
        {
            public string Title;
            public int Pages;

            public Book(string title, int pages)
            {
                Title = title;
                Pages = pages;
            }
        }

        public void SortBooksByPages()
        {
            Book[] books =
            {
                new Book("C# Basics", 180),
                new Book("Data Structures", 420),
                new Book("Algorithms", 350),
                new Book("OOP Concepts", 250)
            };

            // Bubble sort (manual sorting — no LINQ)
            for (int i = 0; i < books.Length - 1; i++)
            {
                for (int j = 0; j < books.Length - i - 1; j++)
                {
                    if (books[j].Pages > books[j + 1].Pages)
                    {
                        Book temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Books sorted by number of pages (ascending):");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title + " - " + book.Pages + " pages");
            }
        }
    }
}
