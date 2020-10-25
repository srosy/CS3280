using BusinessLayer.Models;
using System.Runtime.InteropServices;

namespace BusinessLayer
{
    public static class Utility
    {
        public static int SaveLibraryItem(LibraryItem li, [Optional] int cloneCount)
        {
            if (li == null) return 0;

            var numRowsUpdated = 0;
            if (cloneCount > 1)
            {
                for (int i = 0; i < cloneCount; i++)
                {
                    numRowsUpdated += SaveLibraryItem(li);
                }
            }
            else
            {
                numRowsUpdated += SaveLibraryItem(li);
            }

            return numRowsUpdated; // success > 0
        }

        private static int SaveLibraryItem(LibraryItem libraryItem)
        {
            DataLayer.Utility.LibraryItemAdapter.Fill(DataLayer.Utility.LibraryItems);
            var li = DataLayer.Utility.LibraryItems.NewLibraryItemsRow();
            li.Type = libraryItem.Type;
            li.Title = libraryItem.Title;
            li.Genre = libraryItem.Genre;
            li.Location = libraryItem.Location;
            li.ISBN = libraryItem.ISBN;
            li.Edition = libraryItem.Edition;
            li.WebUrl = libraryItem.WebUrl;
            li.NumArticles = libraryItem.NumArticles;
            li.Advertisers = libraryItem.Advertisers;
            li.Publisher = libraryItem.Publisher;
            li.Author = libraryItem.Author;
            li.VolumeNum = libraryItem.VolumeNum;
            li.ISSN = libraryItem.ISSN;

            return DataLayer.Utility.SaveLibraryItem(li) ? 1 : 0;
        }
    }
}
