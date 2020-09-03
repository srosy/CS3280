using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class Catalog
    {
        public HashSet<Book> Books { get; set; } // hashset doesn't allow duplicate books, plz don't penalize for not using array :)
        public int MAX_CHECKED_OUT_BOOK_ALLOWED_PER_STUDENT { get; set; }
    }
}
