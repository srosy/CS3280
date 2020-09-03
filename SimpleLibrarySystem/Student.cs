using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int W_Number { get; set; }
        public long SSN { get; set; }

        public Student() { }

        public void CheckOutBooks(Catalog catalog, IList<Book> books)
        {
            books.ToList().ForEach(book =>
            {
                CheckOutBook(catalog, book);
            });
        }

        public void CheckOutBook(Catalog catalog, Book book)
        {
            if (!IsAbleToCheckOutBook(catalog))
            {
                Console.WriteLine($"DENIED. Sorry, you can't checkout {book.Title}! You've checked out the max number of books allowed!");
                return;
            }

            if (book.IsBookCheckedOut)
                Console.WriteLine($"DENIED. Sorry! The book {book.Title} is already checked out! Try again later.");
            else
            {
                Console.WriteLine($"APPROVED. {FirstName} {LastName} [W{W_Number}] successfully checked out the book {book.Title}.");
                book.W_NumberCheckedOutBy = W_Number;
            }
        }

        public void ReturnBooks(IList<Book> books)
        {
            books.ToList().ForEach(book =>
            {
                ReturnBook(book);
            });
        }

        public void ReturnBook(Book book)
        {
            if (book.W_NumberCheckedOutBy != W_Number)
            {
                Console.WriteLine($"APPROVED. {FirstName} {LastName} [W{W_Number}] checked in the book {book.Title} that was checked out by [W{book.W_NumberCheckedOutBy}].\nDid {FirstName} {LastName} steal the book?");
                book.W_NumberCheckedOutBy = 0;
            }
            else if (book.IsBookCheckedOut)
            {
                Console.WriteLine($"APPROVED. {FirstName} {LastName} checked in the book {book.Title}.");
                book.W_NumberCheckedOutBy = 0;
            }
            else
            {
                Console.WriteLine($"DENIED. The book {book.Title} is already checked in.");
            }
        }

        public bool IsAbleToCheckOutBook(Catalog catalog)
        {
            return catalog.Books.Count(b => b.W_NumberCheckedOutBy == W_Number) < catalog.MAX_CHECKED_OUT_BOOK_ALLOWED_PER_STUDENT;
        }
    }
}
