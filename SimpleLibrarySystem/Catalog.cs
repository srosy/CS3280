using System.Collections.Generic;

namespace SimpleLibrarySystem
{
    public class Catalog
    {
        public HashSet<Book> Books { get; set; } // hashset doesn't allow duplicate books, plz don't penalize for not using array :)
        public int MAX_CHECKED_OUT_BOOK_ALLOWED_PER_STUDENT { get; set; }
        public int MAX_CHECKED_OUT_BOOK_ALLOWED_PER_INSTRUCTOR { get; set; }
    }
}
