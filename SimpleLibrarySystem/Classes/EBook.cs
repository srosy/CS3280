using System;

namespace SimpleLibrarySystem
{
    public class EBook : Book
    {
        public EBook() { }
        public EBook(Catalog catalog) : base(catalog) { }

        public string URL { get; set; } // assuming all types are accesible in some format online
        public override void Update()
        {
            base.Update();
            Console.WriteLine($"Updating the EBook {Title} - {ISBN_Number}");
        }
    }
}
