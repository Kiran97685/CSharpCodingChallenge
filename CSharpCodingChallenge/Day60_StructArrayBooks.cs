using System;

namespace CSharpCodingChallenge
{
    // Custom struct
    struct Book
    {
        public string Title;
        public string Author;
        public double Rating;
    }

    internal class Day60_StructArrayBooks
    {
        public void AnalyzeBooks()
        {
            Book[] books = new Book[]
            {
                new Book { Title = "Clean Code", Author = "Robert Martin", Rating = 4.8 },
                new Book { Title = "Design Patterns", Author = "GoF", Rating = 4.5 },
                new Book { Title = "Refactoring", Author = "Martin Fowler", Rating = 4.7 },
                new Book { Title = "C# in Depth", Author = "Jon Skeet", Rating = 4.9 }
            };

            double totalRating = 0;
            Book topBook = books[0];

            foreach (Book book in books)
            {
                totalRating += book.Rating;

                if (book.Rating > topBook.Rating)
                {
                    topBook = book;
                }
            }

            double averageRating = totalRating / books.Length;

            Console.WriteLine("Average Rating: " + averageRating);
            Console.WriteLine("Top Rated Book:");
            Console.WriteLine("Title: " + topBook.Title);
            Console.WriteLine("Author: " + topBook.Author);
            Console.WriteLine("Rating: " + topBook.Rating);
        }
    }
}
