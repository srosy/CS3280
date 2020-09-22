using System;

namespace SimpleLibrarySystem
{
    public class EBook : Book
    {
        public EBook() { }
        public EBook(Catalog catalog) : base(catalog) { }

        public string URL { get; set; } // assuming all types are accesible in some format online
        public string HostSite { get; set; }
        public override void Update(LibraryItem itemTo)
        {
            base.Update(itemTo);
            var updateObj = itemTo as EBook;
            URL = updateObj.URL;
            HostSite = updateObj.HostSite;
            Console.WriteLine($"Updating the EBook {Title} - {ISBN_Number}");
        }
    }
}
