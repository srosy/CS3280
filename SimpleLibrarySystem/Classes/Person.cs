using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SimpleLibrarySystem
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private readonly long SSN; // only set from constructor, aka readonly keyword
        public int W_Number { get; set; }
        public string Type { get; set; }
        public abstract string IdString { get; }
        public decimal Fees { get; set; }

        public Person(string fName, string lName, long ssn, [Optional] int wNum) // Optional because Libarian derives and doesn't user wNum
        {
            FirstName = fName;
            LastName = lName;
            SSN = ssn;
            if (wNum > 0) W_Number = wNum;
            Type = GetType().ToString().Split('.')[1];
        }

        public void CheckOutItems(IList<LibraryItem> items)
        {
            items.ToList().ForEach(i =>
            {
                CheckOutItem(i);
                PrintCountItemsCheckedOut(i.CatalogOf);
            });
        }

        public abstract void CheckOutItem(LibraryItem item);


        private void PrintCountItemsCheckedOut(Catalog catalog)
        {
            Console.Write($"Number of items currently checked out by {FirstName} {LastName}: {catalog.Items.Count(i => i.W_NumberCheckedOutBy == W_Number)}/");
            if (Type.ToUpper().Equals("STUDENT"))
                Console.WriteLine(catalog.MAX_CHECKED_OUT_ITEM_ALLOWED_PER_STUDENT);
            else
                Console.WriteLine(catalog.MAX_CHECKED_OUT_ITEM_ALLOWED_PER_INSTRUCTOR);
            Console.WriteLine();
        }

        public void ReturnItems(IList<LibraryItem> items)
        {
            items.ToList().ForEach(i =>
            {
                ReturnItem(i);
            });
        }

        public void ReturnItem(LibraryItem item)
        {
            if (item.IsCheckedOut)
            {
                Console.WriteLine($"APPROVED. {FirstName} {LastName} checked in the item {item.Title}.");
                item.W_NumberCheckedOutBy = 0;
                item.PersonCheckedOutBy = null;

                // charge late fee
                if (DateTime.UtcNow > item.DueDate)
                {
                    Fees += item.ChargeFee();
                    Console.WriteLine($"{item.Title} was returned LATE! You owe a fee of {Fees.ToString("C2")}!");
                }

                item.ReturnDate = DateTime.UtcNow; // assuming system is in UTC
            }
            else
            {
                Console.WriteLine($"DENIED. The item {item.Title} was already checked in on {item.ReturnDate}.");
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

        public void PrintItemInfo(Catalog catalog)
        {
            var booksCheckedOut = catalog.Items.Where(i => i.W_NumberCheckedOutBy == W_Number);
            if (booksCheckedOut.Any())
            {
                Console.WriteLine($"\nItems Checked Out by {FirstName} {LastName}:");
                booksCheckedOut.ToList().ForEach(b =>
                {
                    Console.WriteLine($"{b.Title} [Due: {b.DueDate.ToShortDateString()}]");
                });
            }
            else
                Console.WriteLine($"\nNO items checked out by {FirstName} {LastName}.");
        }

        public bool MaxNumberItemsCheckedOut(Catalog catalog)
        {
            switch (Type)
            {
                case "Instructor":
                    return catalog.Items.Count(i => i.W_NumberCheckedOutBy == W_Number) < catalog.MAX_CHECKED_OUT_ITEM_ALLOWED_PER_INSTRUCTOR;
                case "Student":
                    return catalog.Items.Count(i => i.W_NumberCheckedOutBy == W_Number) < catalog.MAX_CHECKED_OUT_ITEM_ALLOWED_PER_STUDENT;
                default:
                    throw new InvalidOperationException("Object type incompatible.");
            }
        }

        public virtual void AddItem(LibraryItem item) { }
    }
}
