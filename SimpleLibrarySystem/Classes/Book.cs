using System;

namespace SimpleLibrarySystem
{
    public class Book : LibraryItem
    {
        public long ISBN_Number { get; set; }
        public int Edition { get; set; }

        public Book(){ }
        public Book(Catalog catalog) : base(catalog) { }

        public override LibraryItemType LibraryItemType { get => LibraryItemType.BOOK; }
        public override void Update(LibraryItem itemTo)
        {
            base.Update(itemTo);
            var updateObj = itemTo as Book;
            Edition = updateObj.Edition;
            ISBN_Number = updateObj.ISBN_Number;
            Console.WriteLine($"Updating the book {Title} - {ISBN_Number}");
        }
    }
}
