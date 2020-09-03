using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrarySystem
{
    public class Book
    {
        public int BookId { get; set; }
        public long ISBN_Number { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public BookType Type { get; set; }
        public BookLocation Location { get; set; }
        public bool IsBookCheckedOut { get => W_NumberCheckedOutBy > 0; }
        public int W_NumberCheckedOutBy { get; set; }
    }

    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
