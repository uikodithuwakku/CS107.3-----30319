using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
   public class LibraryBook
    {
        public string BookTitle;
        public string BookAuthor;
        public bool BookAvailable;

        public LibraryBook(string Btitle , string Bauthor)
        {
            BookTitle = Btitle;
            BookAuthor = Bauthor;
            BookAvailable = true; // assume that book is available now
        }

        public void BorrowBook()
        {
            if (BookAvailable)
            {
                BookAvailable = false;
                Console.WriteLine($"The book {BookTitle} has been borrowed");
            }
            else
            {
                Console.WriteLine($"Sorry boook {BookTitle} is not available now");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            LibraryBook b1 = new LibraryBook("Famous Five", "Enid Blyton");
            LibraryBook b2 = new LibraryBook("Madol Duwa" , "Martin Wicramasingha");

            b1.BorrowBook();
            b2.BorrowBook();

            LibraryStates(new LibraryBook[] { b1, b2 });

            Console.Read();
        }

        static void LibraryStates(LibraryBook[] books)
        {
            Console.WriteLine("\nLibrary States :");

            for(int i=0; i<books.Length; i++)
            {
                LibraryBook book = books[i];
                Console.WriteLine($"{book.BookTitle} by {book.BookAuthor}");
                Console.WriteLine($"Available : {book.BookAvailable}");
            }
            Console.ReadLine();
        }
    }
}
