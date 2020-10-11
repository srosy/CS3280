using System;

namespace SimpleLibrarySystem
{
    public class Magazine : LibraryItem
    {
        public int NumArticles { get; set; }
        public string[] Advertisers { get; set; }

        public Magazine() { }
        public Magazine(Catalog catalog) : base (catalog) { }

        public override LibraryItemType LibraryItemType { get => LibraryItemType.MAGAZINE; }
        public override void Update(LibraryItem itemTo)
        {
            base.Update(itemTo);
            var updateObj = itemTo as Magazine;
            NumArticles = updateObj.NumArticles;
            Advertisers = updateObj.Advertisers;
            Console.WriteLine($"Updating the magazine {Title}");
        }
    }
}
