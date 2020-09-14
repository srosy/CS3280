using System;

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
        public bool IsBookCheckedOut { get => CheckoutDate > ReturnDate; }
        public int W_NumberCheckedOutBy { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime BookDueDate { get; set; }

        public Book()
        {
            CheckoutDate = DateTime.MinValue;
            ReturnDate = DateTime.MinValue;
        }
    }

    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
