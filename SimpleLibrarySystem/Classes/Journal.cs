using System;

namespace SimpleLibrarySystem
{
    public class Journal : LibraryItem
    {
        public int VolumeNumber { get; set; }
        public int ISSN { get; private set; } // International Standard Serial Number

        public Journal()
        {
            ISSN = GetUniqueId();
        }
        public Journal(Catalog catalog) : base(catalog)
        {
            ISSN = GetUniqueId();
        }

        public override LibraryItemType LibraryItemType { get => LibraryItemType.JOURNAL; }
        public override void Update(LibraryItem itemTo)
        {
            base.Update(itemTo);
            var updateObj = itemTo as Journal;
            VolumeNumber = updateObj.VolumeNumber;
            ISSN = updateObj.ISSN;
            Console.WriteLine($"Updating the Journal {Title} - {ISSN}");
        }
    }
}
