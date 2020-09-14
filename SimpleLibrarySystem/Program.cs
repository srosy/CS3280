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

            var random = new Random();
            var catalog = SetupCatalog(random);

            // create some students
            Console.Write("\nGenerating students...");
            Student student1 = new Student("Spencer", "Rosenvall", random.Next(11111111, 99999999), random.Next(11111111, 99999999));
            Student student2 = new Student("Gavin", "Rosenvall", random.Next(11111111, 99999999), random.Next(11111111, 99999999));
            Console.WriteLine("done.");
            student1.UserInfo();
            student2.UserInfo();

            Console.WriteLine($"\nChecking out books for {student1.FirstName} {student1.LastName} [{student1.StudentIdString}]...");
            student1.CheckOutBooks(catalog, catalog.Books.Take(4).ToList());
            student1.PrintBookInfo(catalog);

            Console.WriteLine($"\nChecking out books for {student2.FirstName} {student2.LastName} [{student2.StudentIdString}]...");
            student2.CheckOutBooks(catalog, catalog.Books.Take(catalog.Books.Count).ToList());
            student2.PrintBookInfo(catalog);

            // return all but one book for student1
            Console.WriteLine($"\nReturning books for {student1.FirstName} {student1.LastName} [{student1.StudentIdString}]...");
            student1.ReturnBooks(catalog.Books.Where(b => b.W_NumberCheckedOutBy == int.Parse(student1.StudentIdString.Substring(1))).Take(2).ToList());

            // student2 stole student1's book but returned it eventually
            Console.WriteLine($"\nReturning books for {student2.FirstName} {student2.LastName} [{student2.StudentIdString}]...");
            student2.ReturnBooks(catalog.Books.Where(b => b.W_NumberCheckedOutBy == int.Parse(student1.StudentIdString.Substring(1))).ToList());

            student2.ReturnBooks(catalog.Books.Where(b => b.IsBookCheckedOut).ToList()); // return all the remaining books

            Console.WriteLine("\nAll books are checked in.\n\nStarting Instructor Criterion...");
            Instructor instructor = new Instructor("Christi", "Arpit", random.Next(111111111, 999999999), random.Next(111111111, 999999999));
            instructor.UserInfo();

            Console.WriteLine($"\nChecking out books for {instructor.FirstName} {instructor.LastName} [{instructor.InstructorIdString}]...");
            instructor.CheckOutBooks(catalog, catalog.Books.ToList()); // try and check out all the books
            instructor.PrintBookInfo(catalog);

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

        public static Catalog SetupCatalog(Random random)
        {
            // catalog
            Console.Write("\nGenerating Catalog...");
            Catalog catalog = new Catalog()
            {
                MAX_CHECKED_OUT_BOOK_ALLOWED_PER_STUDENT = 3,
                MAX_CHECKED_OUT_BOOK_ALLOWED_PER_INSTRUCTOR = 5,
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
            Librarian librarian = new Librarian("Cindy-Loo", "Hoo", random.Next(11111, 99999), "123 Hoo St.", random.Next(11111, 99999));
            Console.WriteLine("done.");
            librarian.UserInfo();

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

            return catalog;
        }
    }
}
