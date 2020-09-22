using System;

namespace SimpleLibrarySystem
{
    public class Journal : LibraryItem
    {
        public int VolumeNumber { get; set; }
        private int _issn;
        public int ISSN { get => _issn; } // International Standard Serial Number

        public Journal()
        {
            _issn = GetUniqueId();
        }
        public Journal(Catalog catalog) : base(catalog)
        {
            _issn = GetUniqueId();
        }

        public override LibraryItemType LibraryItemType { get => LibraryItemType.JOURNAL; }
        public override void Update()
        {
            base.Update();
            Console.WriteLine($"Updating the Journal {Title} - {ISSN}");
        }
    }
}
