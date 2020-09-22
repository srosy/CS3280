using System.Collections.Generic;

namespace SimpleLibrarySystem
{
    public class Catalog
    {
        public IList<LibraryItem> Items { get; set; } = new List<LibraryItem>();
        public int MAX_CHECKED_OUT_ITEM_ALLOWED_PER_STUDENT { get; set; } = 3;
        public int MAX_CHECKED_OUT_ITEM_ALLOWED_PER_INSTRUCTOR { get; set; } = 5;

        public void AddItem(LibraryItem item) => Items.Add(item);
        public void RemoveItem(LibraryItem item) => Items.Remove(item);
    }
}
