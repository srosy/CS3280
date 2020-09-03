using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Starting Simple Library System ***");

            // catalog
            Console.Write("\nGenerating Catalog...");
            Catalog catalog = new Catalog()
            {
                MAX_CHECKED_OUT_BOOK_ALLOWED_PER_STUDENT = 3,
                #region Generate Books
                Books = new HashSet<Book>()
                {
                    new Book()
                    {
                        BookId = 1,
                        ISBN_Number = 9781400079988,
                        Title = "War and Peace",
                        Author = new Author() {FirstName = "Leo", LastName = "Tolstoy"},
                        Type = BookType.EDUCATION,
                        Location = BookLocation.THIRD_FLOOR
                    },
                    new Book()
                    {
                        BookId = 2,
                        ISBN_Number = 9780743273565,
                        Title = "The Great Gasby",
                        Author = new Author() {FirstName = "F. Scott", LastName = "Fitzgerald"},
                        Type = BookType.SCIENCE,
                        Location = BookLocation.SECOND_FLOOR
                    },
                    new Book()
                    {
                        BookId = 3,
                        ISBN_Number = 9780812550702,
                        Title = "Ender's Game",
                        Author = new Author() {FirstName = "Orson Scott", LastName = "Card"},
                        Type = BookType.FICTION,
                        Location = BookLocation.SECOND_FLOOR
                    }
                }
                #endregion
            };
            Console.WriteLine("done.");

            // libarian
            Console.Write("\nGenerating Librarian...");
            Librarian librarian = new Librarian()
            {
                EmployeeId = 34574,
                Address = "123 Hoo St.",
                FirstName = "Cindy-Loo",
                LastName = "Hoo",
                SSN = 234877435
            };
            Console.WriteLine("done.");
            PrintProperties(librarian);

            // add books
            Console.WriteLine("\nGenerating books for catalog...");
            librarian.AddBook(new Book()
            {
                BookId = 4,
                ISBN_Number = 9780679723165,
                Title = "Lolita",
                Author = new Author() { FirstName = "Vladimir", LastName = "Nabokov" },
                Type = BookType.FICTION,
                Location = BookLocation.SECOND_FLOOR
            }, catalog);
            librarian.AddBook(new Book()
            {
                BookId = 5,
                ISBN_Number = 9780553213119,
                Title = "Moby Dick",
                Author = new Author() { FirstName = "Herman", LastName = "Melville" },
                Type = BookType.FICTION,
                Location = BookLocation.SECOND_FLOOR
            }, catalog);
            librarian.AddBook(new Book()
            {
                BookId = 6,
                ISBN_Number = 9781849836883,
                Title = "The Crusades",
                Author = new Author() { FirstName = "Thomas", LastName = "Asbridge" },
                Type = BookType.HISTORY,
                Location = BookLocation.FIRST_FLOOR
            }, catalog);

            Console.WriteLine("Print books in Catalog...");
            catalog.Books.ToList().ForEach(b =>
            {
                PrintProperties(b);
            });

            // try adding a duplicate book
            Console.WriteLine("\nTest adding a duplicate book...");
            librarian.AddBook(new Book()
            {
                BookId = 2,
                ISBN_Number = 9780743273565,
                Title = "The Great Gasby",
                Author = new Author() { FirstName = "F. Scott", LastName = "Fitzgerald" },
                Type = BookType.FICTION,
                Location = BookLocation.SECOND_FLOOR
            }, catalog);

            // create some students
            Console.Write("\nGenerating students...");
            var random = new Random();
            Student student1 = new Student()
            {
                FirstName = "Spencer",
                LastName = "Rosenvall",
                W_Number = random.Next(11111111, 99999999),
                SSN = random.Next(111111111, 999999999)
            };
            Student student2 = new Student()
            {
                FirstName = "Gavin",
                LastName = "Rosenvall",
                W_Number = random.Next(11111111, 99999999),
                SSN = random.Next(111111111, 999999999)
            };
            Console.WriteLine("done.");
            PrintProperties(student1);
            PrintProperties(student2);

            Console.WriteLine($"\nChecking out books for {student1.FirstName} {student1.LastName} [W{student1.W_Number}]...");
            student1.CheckOutBooks(catalog, catalog.Books.Take(4).ToList());

            Console.WriteLine($"\nChecking out books for {student2.FirstName} {student2.LastName} [W{student2.W_Number}]...");
            student2.CheckOutBooks(catalog, catalog.Books.Take(catalog.Books.Count).ToList());

            // return all but one book for student1
            Console.WriteLine($"\nReturning books for {student1.FirstName} {student1.LastName} [W{student1.W_Number}]...");
            student1.ReturnBooks(catalog.Books.Where(b => b.W_NumberCheckedOutBy == student1.W_Number).Take(2).ToList());

            // student2 stole student1's book but returned it eventually
            Console.WriteLine($"\nReturning books for {student2.FirstName} {student2.LastName} [W{student2.W_Number}]...");
            student2.ReturnBooks(catalog.Books.Where(b => b.W_NumberCheckedOutBy == student1.W_Number).ToList());

            Console.WriteLine("\n*** Simple Library System Program DONE ***");
            Console.ReadLine();
        }

        private static void PrintProperties(object obj)
        {
            Console.WriteLine($"\nPrinting {obj.GetType().GetTypeInfo().Name}...");
            obj.GetType().GetProperties().ToList().ForEach(p =>
            {
                Console.WriteLine($"{p.Name} : {p.GetValue(obj)}");
            });
        }
    }
}
