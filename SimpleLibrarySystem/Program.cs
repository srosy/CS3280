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
            Console.WriteLine("********************** Starting Simple Library System **********************");

            var random = new Random();
            var catalog = SetupCatalog(random);

            // create some students using runtime polymorphism
            Console.Write("\n *** Generating students ***");
            Person p1 = new Student("Spencer", "Rosenvall", random.Next(11111111, 99999999), random.Next(11111111, 99999999));
            Console.WriteLine("done.");
            p1.UserInfo();

            // student 1 checks out items of different types
            Console.WriteLine($"\n*** Checking out items for {p1.FirstName} {p1.LastName} [{p1.IdString}] ***");
            p1.CheckOutItems(catalog.Items.Take(4).ToList());
            p1.PrintItemInfo(catalog);

            // return all the remaining items
            Console.WriteLine($"\n*** Return all library items ***");
            p1.ReturnItems(catalog.Items.Where(i => i.IsCheckedOut).ToList());

            // generate an instructor using runtime polymorphism
            Console.WriteLine("\n *** All items are checked in.\n\nStarting Instructor Criterion ***");
            Person instructor = new Instructor("Christi", "Arpit", random.Next(111111111, 999999999), random.Next(111111111, 999999999));
            instructor.UserInfo();

            // instructor checks-out items
            Console.WriteLine($"\n*** Checking out items for {instructor.FirstName} {instructor.LastName} [{instructor.IdString}] ***");
            instructor.CheckOutItems(catalog.Items.Take(6).ToList()); // try and check out all the books
            instructor.PrintItemInfo(catalog);
            instructor.ReturnItems(catalog.Items.Where(i => i.W_NumberCheckedOutBy == int.Parse(instructor.IdString.Substring(1))).ToList());

            Console.WriteLine("\n****** Run-time Polymorphism Requirements ******\n");

            // instructor turns item in late and gets fee
            Console.WriteLine("\nInstructor returns book late and gets fee:");
            var book = catalog.Items.First(i => !i.IsCheckedOut && i.LibraryItemType == LibraryItemType.BOOK);
            instructor.CheckOutItem(book);
            book.DueDate = DateTime.MinValue;
            instructor.ReturnItem(book);
            Console.WriteLine("done.");

            // student turns item in late and gets fee
            Console.WriteLine("\nStudent returns magazine late and gets fee:");
            var magazine = catalog.Items.First(i => !i.IsCheckedOut && i.LibraryItemType == LibraryItemType.MAGAZINE);
            p1.CheckOutItem(magazine);
            magazine.DueDate = DateTime.MinValue;
            p1.ReturnItem(magazine);
            Console.WriteLine("done.");

            // catalog is long and hard to read, so remove some items...
            catalog.Items = catalog.Items.Take(3).ToList();
            
            // system take item from catalog
            var randoItem = catalog.Items[random.Next(0, catalog.Items.Count - 1)];
            Console.WriteLine($"\nPrint items in Catalog, remove item [{randoItem.Title}], print catalog again\n");
            catalog.Items.ToList().ForEach(i =>
            {
                PrintProperties(i);
            });
            Console.WriteLine($"\nTaking Item [{randoItem.Title}] from the shelf now\n");
            randoItem.TakeFromShelf();
            catalog.Items.ToList().ForEach(i =>
            {
                PrintProperties(i);
            });
            Console.WriteLine("done.");


            // utilizing ICloneable
            randoItem = catalog.Items[random.Next(0, catalog.Items.Count - 1)];
            Console.WriteLine($"\n*** Utlizing ICloneable and adding duplicate item [{randoItem.Title}-(id-{randoItem.Id})]. ***");
            var clone = randoItem.GetClone();
            catalog.AddItem(clone);
            Console.WriteLine($"\nItem [{clone.Title}(id-{clone.Id})] added and reprinting catalog\n");
            catalog.Items.ToList().ForEach(i =>
            {
                PrintProperties(i);
            });
            Console.WriteLine("done.");

            // updating an item from catalog, changing Genre.
            Console.WriteLine($"\n*** Updating a random item's genre ***");
            randoItem = catalog.Items.Where(i => catalog.Items.Count(j => j.Id == i.Id) < 2).FirstOrDefault();
            PrintProperties(randoItem);
            var sameIdClone = randoItem.Clone() as LibraryItem;
            sameIdClone.Genre = Genre.MATH;
            randoItem.Update(sameIdClone);
            PrintProperties(randoItem);
            Console.WriteLine("done.");

            Console.WriteLine("\n********** Run-time Polymorphism Requirements DONE **********\n");

            Console.WriteLine("\n********************** Simple Library System Program DONE **********************");
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
            librarian.UserInfo();

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

            Console.WriteLine("Print items in Catalog...");
            catalog.Items.ToList().ForEach(i =>
            {
                PrintProperties(i);
            });

            return catalog;
        }
    }
}
