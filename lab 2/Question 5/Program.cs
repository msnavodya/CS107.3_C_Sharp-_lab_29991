using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    using System;
    using System.Collections.Generic;

    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; private set; }

        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            Available = true; // By default, when a book is created, it's available
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Sorry, book '{Title}' by {Author} is currently not available.");
            }
        }

        public void ReturnBook()
        {
            if (!Available)
            {
                Available = true;
                Console.WriteLine($"Book '{Title}' by {Author} has been returned.");
            }
            else
            {
                Console.WriteLine($"This book is already available in the library.");
            }
        }
    }

    class Library
    {
        private List<LibraryBook> books;

        public Library()
        {
            books = new List<LibraryBook>();
        }

        public void AddBook(LibraryBook book)
        {
            books.Add(book);
        }

        public void DisplayLibraryStatus()
        {
            Console.WriteLine("Library Status:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {book.Available}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Add some books to the library
            library.AddBook(new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald"));
            library.AddBook(new LibraryBook("To Kill a Mockingbird", "Harper Lee"));
            library.AddBook(new LibraryBook("1984", "George Orwell"));

            
        }
    }
}
