using System;
using System.Linq;

namespace SimpleLibrarySystem
{
    public class Librarian : Person
    {
        protected string Address { get; set; }
        protected int EmployeeId { get; set; }

        public override string IdString { get => EmployeeId.ToString(); }

        public Librarian(string fName, string lName, long ssn, string address, int employeeId) : base(fName, lName, ssn)
        {
            Address = address;
            EmployeeId = employeeId;
        }

        public override void AddItem(LibraryItem item)
        {
            item.CatalogOf.Items.Add(item);
            Console.WriteLine($"SUCCESS. Added the item {item.Title} to the catalog!");
        }

        // I'd normally keep this in Person.cs but you required it to be overridden here and abstract in the base class
        public override void CheckOutItem(LibraryItem item) 
        {
            if (!MaxNumberItemsCheckedOut(item.CatalogOf))
            {
                Console.WriteLine($"DENIED. Sorry, you can't checkout {item.Title}! You've checked out the max number of items allowed!");
                return;
            }

            if (item.IsCheckedOut)
                Console.WriteLine($"DENIED. Sorry! The item {item.Title} was already checked out on {item.CheckoutDate.ToShortDateString()}! It's expected to be returned before {item.DueDate.ToShortDateString()}. Try again later.");
            else
            {
                item.CheckoutDate = DateTime.UtcNow; // assuming system is in UTC
                item.DueDate = item.MaxCheckoutTime(Type);
                Console.WriteLine($"APPROVED. {FirstName} {LastName} successfully checked out the item {item.Title}. Item is due: {item.DueDate.ToShortDateString()}.");
                item.W_NumberCheckedOutBy = W_Number;
                item.PersonCheckedOutBy = this;
            }
        }
    }
}
