using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class Librarian
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long SSN { get; set; }
        public int EmployeeId { get; set; }

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
