﻿using System;

namespace SimpleLibrarySystem
{
    public class Instructor : Person
    {
        public override string IdString { get => $"E{W_Number}"; }

        public Instructor(string fName, string lName, long ssn, int wNum) : base(fName, lName, ssn, wNum) { }

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
                item.DueDate = DateTime.UtcNow.AddDays(item.MaxCheckoutTime(Type));
                Console.WriteLine($"APPROVED. {FirstName} {LastName} successfully checked out the item {item.Title}. Item is due: {item.DueDate.ToShortDateString()}.");
                item.W_NumberCheckedOutBy = W_Number;
            }
        }
    }
}