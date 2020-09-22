using SimpleLibrarySystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SimpleLibrarySystem
{
    public abstract class LibraryItem : ILateFee, ICloneable
    {
        public int Id { get; set; } // ICloneable
        public int W_NumberCheckedOutBy { get; set; }

        public Author Author { get; set; }

        public string Title { get; set; }
        public string Publisher { get; set; }

        public DateTime CheckoutDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime DueDate { get; set; }

        public Catalog CatalogOf { get; set; }

        public bool IsCheckedOut { get => CheckoutDate > ReturnDate; }

        public Genre Genre { get; set; }
        public ItemLocation Location { get; set; }
        public abstract LibraryItemType LibraryItemType { get; }

        public LibraryItem([Optional] Catalog catalog)
        {
            CheckoutDate = DateTime.MinValue;
            ReturnDate = DateTime.MinValue;
            if (catalog != null) CatalogOf = catalog;
            Id = GetUniqueId();
        }

        public DateTime MaxCheckoutTime(string type) => (type.ToLower().Equals("instructor") && this.LibraryItemType == LibraryItemType.EBOOK) ? DateTime.UtcNow.AddMonths(3)
            : (this.LibraryItemType == LibraryItemType.JOURNAL) ? DateTime.UtcNow.AddMonths(2)
            : (this.LibraryItemType == LibraryItemType.MAGAZINE && type.ToLower().Equals("student")) ? DateTime.UtcNow.AddDays(14) //.50 = 2 weeks, 1 = 1 month 
            : (this.LibraryItemType == LibraryItemType.MAGAZINE && type.ToLower().Equals("instructor")) ? DateTime.UtcNow.AddDays(3) //.75 = 3 weeks, 1 = 1 month 
            : (type.ToLower().Equals("instructor")) ? DateTime.UtcNow.AddMonths(3) : DateTime.UtcNow.AddMonths(2);

        public decimal ChargeFee() => this.LibraryItemType == LibraryItemType.BOOK ? 1.00m : 0.50m; // ILateFee
        public virtual void Update(LibraryItem itemTo)
        { // make sure this is actually updating the item
            if (this.GetType() != itemTo.GetType() || this.LibraryItemType != itemTo.LibraryItemType)
                throw new ArgumentException("object types must be the same.");

            Id = itemTo.Id;
            W_NumberCheckedOutBy = itemTo.W_NumberCheckedOutBy;
            Title = itemTo.Title;
            ReturnDate = itemTo.ReturnDate;
            CheckoutDate = itemTo.CheckoutDate;
            DueDate = itemTo.DueDate;
            Publisher =  itemTo.Publisher;
            Genre = itemTo.Genre;
            Location = itemTo.Location;
            DueDate = itemTo.DueDate;
            CatalogOf = itemTo.CatalogOf;
            Author = itemTo.Author;
        }
        public void TakeFromShelf() => CatalogOf.Items.Remove(this);

        public int GetUniqueId([Optional] Random random)
        {
            if (random == null)
                random = new Random();

            var id = random.Next(0, 999999);
            if (CatalogOf.Items.Any(i => i.Id == id))
                return GetUniqueId(random);
            return id;
        }

        #region Clone
        public IList<LibraryItem> GetClones(int number)
        {
            var clones = new List<LibraryItem>();

            for (int i = 0; i < number; i++)
                clones.Add(GetClone());

            return clones;
        }

        public LibraryItem GetClone()
        {
            var clone = this.Clone() as LibraryItem;
            clone.Id = GetUniqueId();
            return clone;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
        #endregion
    }
}
