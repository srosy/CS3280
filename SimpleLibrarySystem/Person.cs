using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SimpleLibrarySystem
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private readonly long SSN; // only set from constructor, aka readonly keyword
        protected int W_Number { get; set; }
        private string Type;

        public Person(string fName, string lName, long ssn, [Optional] int wNum) // Optional because Libarian derives and doesn't user wNum
        {
            FirstName = fName;
            LastName = lName;
            SSN = ssn;
            if (wNum > 0) W_Number = wNum;
            Type = GetType().ToString().Split('.')[1];
        }

        public void CheckOutBooks(Catalog catalog, IList<Book> books)
        {
            books.ToList().ForEach(book =>
            {
                CheckOutBook(catalog, book);
            });
        }

        public void CheckOutBook(Catalog catalog, Book book)
        {
            if (!MaxNumBooksCheckedOut(catalog))
            {
                Console.WriteLine($"DENIED. Sorry, you can't checkout {book.Title}! You've checked out the max number of books allowed!");
                return;
            }

            if (book.IsBookCheckedOut)
                Console.WriteLine($"DENIED. Sorry! The book {book.Title} was already checked out on {book.CheckoutDate.ToShortDateString()}! It's expected to be returned before {book.BookDueDate.ToShortDateString()}. Try again later.");
            else
            {
                book.CheckoutDate = DateTime.UtcNow; // assuming system is in UTC
                book.BookDueDate = GetType().ToString().Split('.')[1].Equals("Instructor") ? book.CheckoutDate.AddMonths(2) : book.CheckoutDate.AddMonths(1);
                Console.WriteLine($"APPROVED. {FirstName} {LastName} successfully checked out the book {book.Title}. Book is due: {book.BookDueDate.ToShortDateString()}.");
                book.W_NumberCheckedOutBy = W_Number;
            }

            PrintCountBooksCheckedOut(catalog);
        }

        private void PrintCountBooksCheckedOut(Catalog catalog)
        {
            Console.Write($"Number of books currently checked out by {FirstName} {LastName}: {catalog.Books.Count(b => b.W_NumberCheckedOutBy == W_Number)}/");
            if (Type.ToUpper().Equals("STUDENT"))
                Console.WriteLine(catalog.MAX_CHECKED_OUT_BOOK_ALLOWED_PER_STUDENT);
            else
                Console.WriteLine(catalog.MAX_CHECKED_OUT_BOOK_ALLOWED_PER_INSTRUCTOR);
            Console.WriteLine();
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
                Console.WriteLine($"APPROVED. {FirstName} {LastName} checked in the book {book.Title} that was checked out by somebody else. Did {FirstName} {LastName} steal the book?");
                book.W_NumberCheckedOutBy = 0;
                book.ReturnDate = DateTime.UtcNow; // assuming system is in UTC
            }
            else if (book.IsBookCheckedOut)
            {
                Console.WriteLine($"APPROVED. {FirstName} {LastName} checked in the book {book.Title}.");
                book.W_NumberCheckedOutBy = 0;
                book.ReturnDate = DateTime.UtcNow; // assuming system is in UTC
            }
            else
            {
                Console.WriteLine($"DENIED. The book {book.Title} was already checked in on {book.ReturnDate}.");
            }
        }

        public void UserInfo()
        {
            Console.WriteLine($"\n***** Printing Info for {FirstName} {LastName} *****");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"SSN: {SSN}");
            Console.WriteLine($"W_Number: {W_Number}");
            Console.WriteLine($"Type: {Type}");
        }

        public void PrintBookInfo(Catalog catalog)
        {
            var booksCheckedOut = catalog.Books.Where(b => b.W_NumberCheckedOutBy == W_Number);
            if (booksCheckedOut.Any())
            {
                Console.WriteLine($"\nBooks Checked Out by {FirstName} {LastName}:");
                booksCheckedOut.ToList().ForEach(b => {
                    Console.WriteLine($"{b.Title} [Due: {b.BookDueDate.ToShortDateString()}]");
                });
            }
            else
                Console.WriteLine($"\nNO books checked out by {FirstName} {LastName}.");
        }

        public bool MaxNumBooksCheckedOut(Catalog catalog)
        {
            switch (Type)
            {
                case "Instructor":
                    return catalog.Books.Count(b => b.W_NumberCheckedOutBy == W_Number) < catalog.MAX_CHECKED_OUT_BOOK_ALLOWED_PER_INSTRUCTOR;
                case "Student":
                    return catalog.Books.Count(b => b.W_NumberCheckedOutBy == W_Number) < catalog.MAX_CHECKED_OUT_BOOK_ALLOWED_PER_STUDENT;
                default:
                    throw new InvalidOperationException("Object type incompatible.");
            }
        }
    }
}
