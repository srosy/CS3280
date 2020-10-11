using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SimpleLibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************** Starting Simple Library Setup **********************");

            var random = new Random();
            var catalog = SetupCatalog(random);

            // create some students and add students to the a list
            Console.Write("\n *** Generating students ***");
            var persons = new List<Person>() {
            new Student("Spencer", "Rosenvall", random.Next(11111111, 99999999), random.Next(11111111, 99999999)),
            new Student("Gavin", "Rosenvall", random.Next(11111111, 99999999), random.Next(11111111, 99999999)),
            new Student("Caelei", "Rosenvall", random.Next(11111111, 99999999), random.Next(11111111, 99999999)),
            new Student("Harry", "Potter", random.Next(11111111, 99999999), random.Next(11111111, 99999999)),
            new Student("Hermoine", "Granger", random.Next(11111111, 99999999), random.Next(11111111, 99999999)),
            new Student("Mia", "Potter", random.Next(11111111, 99999999), random.Next(11111111, 99999999)),
            new Student("Father", "Granger", random.Next(11111111, 99999999), random.Next(11111111, 99999999))
            }; // list to store all person objects
            Console.WriteLine("done.");

            // generate instructors and add to the list
            Console.Write("\n *** Generating instructors ***");
            persons.Add(new Instructor("Christi", "Arpit", random.Next(111111111, 999999999), random.Next(111111111, 999999999)));
            persons.Add(new Instructor("Nikola", "Tesla", random.Next(111111111, 999999999), random.Next(111111111, 999999999)));
            persons.Add(new Instructor("Albert", "Einstein", random.Next(111111111, 999999999), random.Next(111111111, 999999999)));
            Console.WriteLine("done.");

            // check out random items for random people
            Console.Write("\n *** Checking out items ***");
            for (int i = 0; i < persons.Count - 1; i++)
            {
                var person = persons[i];
                for (int j = 0; j < random.Next(1, person.Type.ToLower().Equals("student") ? catalog.MAX_CHECKED_OUT_ITEM_ALLOWED_PER_STUDENT
                    : catalog.MAX_CHECKED_OUT_ITEM_ALLOWED_PER_INSTRUCTOR); j++)
                {
                    if (j == 0)
                        person.CheckOutItem(catalog.Items.Where(item => item.LibraryItemType == LibraryItemType.BOOK).ToList()[random.Next(0, catalog.Items.Where(item => item.LibraryItemType == LibraryItemType.BOOK).Count() - 1)]);
                    else
                        person.CheckOutItem(catalog.Items[random.Next(0, catalog.Items.Count - 1)]);
                }
            }
            Console.WriteLine("done.");

            Console.WriteLine("\n********************** Simple Library System Setup DONE **********************");
            Console.WriteLine("\n****** List and LINQ Requirements ******\n");

            IEnumerable<Person> students = persons.Where(p => p.Type.ToLower() == "student");
            Console.WriteLine($"Select a lastname for a student from these available last names " +
                $"({string.Join(", ", students.Select(p => p.LastName).Distinct().ToList())})");
            var lname = Console.ReadLine().ToLower();

            if (students.Select(p => p.LastName.ToLower()).Contains(lname))
            {
                var student = students.FirstOrDefault(s => s.LastName.ToLower().Equals(lname));
                var booksCheckedOutByStudent = catalog.Items.Where(b => b.LibraryItemType == LibraryItemType.BOOK && b.PersonCheckedOutBy == students.FirstOrDefault(s => s.LastName.ToLower().Equals(lname))).OrderBy(b => b.ReturnDate);
                var query = "catalog.Items.Where(b => b.LibraryItemType == LibraryItemType.BOOK && b.PersonCheckedOutBy == students.FirstOrDefault(s => s.LastName.ToLower().Equals(lname))).OrderBy(b => b.ReturnDate);";
                Console.WriteLine($"\nQuery to find books checked out by {student.FirstName} {student.LastName}:\n {query}");
                Console.WriteLine($"Books checked out by {student.FirstName} {student.LastName}: {(booksCheckedOutByStudent.Count() <= 0 ? "NONE" : string.Join(", ", booksCheckedOutByStudent.Select(b => b.Title)))}");

                // assuming we're using the same lastname as inputted
                var person = persons.FirstOrDefault(s => s.LastName.ToLower().Equals(lname));
                query = "catalog.Items.Where(b => b.PersonCheckedOutBy == persons.FirstOrDefault(s => s.LastName.ToLower().Equals(lname))).OrderBy(b => b.ReturnDate);";
                var itemsCheckedOutByPerson = catalog.Items.Where(b => b.PersonCheckedOutBy == persons.FirstOrDefault(s => s.LastName.ToLower().Equals(lname))).OrderBy(b => b.ReturnDate);
                Console.WriteLine($"\nQuery to find items checked out by {person.FirstName} {person.LastName}:\n {query}");
                Console.WriteLine($"Items checked out by {person.FirstName} {person.LastName}: {(itemsCheckedOutByPerson.Count() <= 0 ? "NONE" : string.Join(", ", itemsCheckedOutByPerson.Select(i => i.Title)))}");

                Console.WriteLine($"\n *** Notify all library users of items due tomorrow ***");
                for (int i = 0; i < random.Next(1, catalog.Items.Count(item => item.IsCheckedOut)); i++)
                {
                    catalog.Items[i].DueDate = DateTime.UtcNow.AddMinutes(1439);
                }

                var itemsCheckedOutAndDueInOneDay = catalog.Items.Where(b => b.IsCheckedOut && b.DueDate < DateTime.UtcNow.AddDays(1)).ToList();
                if (itemsCheckedOutAndDueInOneDay.Count > 0)
                {
                    itemsCheckedOutAndDueInOneDay.ForEach(b =>
                    {
                        var user = persons.FirstOrDefault(p => p.W_Number == b.W_NumberCheckedOutBy);
                        Console.WriteLine($"\n[{user.IdString}] {user.FirstName} {user.LastName} - The due date for {b.Title} is tomorrow");
                    });
                }
                else
                {
                    Console.WriteLine("No items due within a day");
                }
            }
            else
            {
                Console.WriteLine("Invalid lastname input. Program exiting with -1");
            }

            Console.WriteLine("\n****** List and LINQ Requirements DONE ******\n");
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
            Catalog catalog = new Catalog();
            #region Generate Books
            var Items = new List<LibraryItem>()
            {
                new Book(catalog)
                {
                    ISBN_Number = 9781400079988,
                    Title = "War and Peace",
                    Author = new Author() {FirstName = "Leo", LastName = "Tolstoy"},
                    Genre = Genre.EDUCATION,
                    Location = ItemLocation.THIRD_FLOOR
                },
                new Book(catalog)
                {
                    ISBN_Number = 9780743273565,
                    Title = "The Great Gasby",
                    Author = new Author() {FirstName = "F. Scott", LastName = "Fitzgerald"},
                    Genre = Genre.SCIENCE,
                    Location = ItemLocation.SECOND_FLOOR
                },
                new Book(catalog)
                {
                    ISBN_Number = 9780812550702,
                    Title = "Ender's Game",
                    Author = new Author() {FirstName = "Orson Scott", LastName = "Card"},
                    Genre = Genre.FICTION,
                    Location = ItemLocation.SECOND_FLOOR
                }
            };

            Items.ForEach(i => i.CatalogOf = catalog);
            catalog.Items = Items;
            Console.WriteLine("done.");
            #endregion

            // librarian
            Console.Write("\nGenerating Librarian...");
            Person librarian = new Librarian("Cindy-Loo", "Hoo", random.Next(11111, 99999), "123 Hoo St.", random.Next(11111, 99999));
            Console.WriteLine("done.");
            //librarian.UserInfo();

            // add books and ebooks
            #region AddMoreBooks
            Console.WriteLine("\nGenerating books for catalog...");
            librarian = (Librarian)librarian;
            librarian.AddItem(new Book(catalog) // add via librarian
            {
                ISBN_Number = 9780679723165,
                Title = "Lolita",
                Author = new Author() { FirstName = "Vladimir", LastName = "Nabokov" },
                Genre = Genre.FICTION,
                Location = ItemLocation.SECOND_FLOOR
            });

            catalog.AddItem(new Book(catalog) // add via catalog
            {
                ISBN_Number = 9780553213119,
                Title = "Moby Dick",
                Author = new Author() { FirstName = "Herman", LastName = "Melville" },
                Genre = Genre.FICTION,
                Location = ItemLocation.SECOND_FLOOR
            });

            LibraryItem b1 = new Book(catalog)
            {
                ISBN_Number = 9781849836883,
                Title = "The Crusades",
                Author = new Author() { FirstName = "Thomas", LastName = "Asbridge" },
                Genre = Genre.HISTORY,
                Location = ItemLocation.FIRST_FLOOR
            };
            librarian.AddItem(b1);

            LibraryItem eb1 = new EBook(catalog)
            {
                ISBN_Number = 9781846856883,
                Title = "Mein Kampf",
                Author = new Author() { FirstName = "Adolf", LastName = "Hitler" },
                Genre = Genre.HISTORY,
                Location = ItemLocation.THIRD_FLOOR,
                Edition = 4,
                Publisher = "UNKNOWN",
                URL = "https://ebooks.com/mein-kampf",
                HostSite = "Kindle"
            };
            librarian.AddItem(eb1);

            // add a clone
            var clone = b1.GetClone();
            librarian.AddItem(clone);
            #endregion

            // add magazines
            #region AddMagazines
            LibraryItem m1 = new Magazine(catalog)
            {
                Advertisers = new string[] { "Advertiser1", "Advertiser2" },
                Author = new Author() { FirstName = "Sam", LastName = "Hill" },
                NumArticles = 4,
                Title = "Boys' Life",
                Genre = Genre.EDUCATION,
                Location = ItemLocation.FIRST_FLOOR,
                Publisher = "Boys' Life Magazine"
            };
            catalog.AddItem(m1);

            LibraryItem m2 = new Magazine(catalog)
            {
                Advertisers = new string[] { "Advertiser1", "Advertiser2" },
                Author = new Author() { FirstName = "Samantha", LastName = "Hill" },
                NumArticles = 4,
                Title = "Girls' Life",
                Genre = Genre.EDUCATION,
                Location = ItemLocation.FIRST_FLOOR,
                Publisher = "Girls' Life Magazine"
            };
            catalog.AddItem(m2);
            #endregion

            // add journals
            #region Journal
            LibraryItem j1 = new Journal(catalog)
            {
                Author = new Author() { FirstName = "Sammy", LastName = "Hillbilly" },
                Title = "Aliens Among Us",
                Genre = Genre.SCIENCE,
                Location = ItemLocation.SECOND_FLOOR,
                Publisher = "SpaceX",
                VolumeNumber = 5
            };
            catalog.AddItem(j1);

            LibraryItem j2 = new Journal(catalog)
            {
                Author = new Author() { FirstName = "Sarah", LastName = "Hillbilly" },
                Title = "My Boring Life",
                Genre = Genre.HISTORY,
                Location = ItemLocation.THIRD_FLOOR,
                Publisher = "Netflix",
                VolumeNumber = 1
            };
            catalog.AddItem(j2);
            #endregion

            //Console.WriteLine("Print items in Catalog...");
            //catalog.Items.ToList().ForEach(i =>
            //{
            //    PrintProperties(i);
            //});

            return catalog;
        }
    }
}
