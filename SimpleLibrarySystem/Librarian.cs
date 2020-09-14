using System;
using System.Linq;

namespace SimpleLibrarySystem
{
    public class Librarian : Person
    {
        protected string Address { get; set; }
        protected int EmployeeId { get; set; }

        public Librarian(string fName, string lName, long ssn, string address, int employeeId) : base(fName, lName, ssn)
        {
            Address = address;
            EmployeeId = employeeId;
        }

        public void AddBook(Book book, Catalog catalog)
        {
            Console.Write("Adding book...");
            if (catalog.Books.Any(b => b.ISBN_Number == book.ISBN_Number))
                Console.WriteLine($"FAILED. The book {book.Title} already exists in the catalog!");
            else
            {
                catalog.Books.Add(book);
                Console.WriteLine($"SUCCESS. Added the book {book.Title} to the catalog!");
            }
        }
    }
}
