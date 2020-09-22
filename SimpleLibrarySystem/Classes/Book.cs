using System;

namespace SimpleLibrarySystem
{
    public class Book : LibraryItem
    {
        public int BookId { get; set; }
        public long ISBN_Number { get; set; }
        public int Edition { get; set; }

        public Book(){ }
        public Book(Catalog catalog) : base(catalog) { }

        public override LibraryItemType LibraryItemType { get => LibraryItemType.BOOK; }
        public override void Update()
        {
            base.Update();
            Console.WriteLine($"Updating the book {Title} - {ISBN_Number}");
        }
    }
}
