using SimpleLibrarySystem.Interfaces;
using System;
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

        public double MaxCheckoutTime(string type) => (type.ToLower().Equals("instructor") && this.LibraryItemType == LibraryItemType.EBOOK) ? 3
            : (this.LibraryItemType == LibraryItemType.JOURNAL) ? 2
            : (this.LibraryItemType == LibraryItemType.MAGAZINE && type.ToLower().Equals("student")) ? .50d //.50 = 2 weeks, 1 = 1 month 
            : (this.LibraryItemType == LibraryItemType.MAGAZINE && type.ToLower().Equals("instructor")) ? .75d //.75 = 3 weeks, 1 = 1 month 
            : (type.ToLower().Equals("instructor")) ? 3 : 2;

        public decimal ChargeFee() => this.LibraryItemType == LibraryItemType.BOOK ? 1.00m : 0.50m; // ILateFee
        public virtual void Update()
        { // make sure this is actually updating the item
            var item = CatalogOf.Items.FirstOrDefault(i => i.Id == this.Id);
            item = this;
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

        public object Clone()
        {            
            return MemberwiseClone();
        }
    }
}
