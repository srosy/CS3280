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
        public override void Update()
        {
            base.Update();
            Console.WriteLine($"Updating the magazine {Title}");
        }
    }
}
