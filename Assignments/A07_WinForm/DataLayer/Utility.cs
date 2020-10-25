using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class Utility
    {
        public static readonly ContextTableAdapters.LibraryItemsTableAdapter LibraryItemAdapter
            = new ContextTableAdapters.LibraryItemsTableAdapter();// { ClearBeforeFill = true };
        public static readonly Context.LibraryItemsDataTable LibraryItems = new Context.LibraryItemsDataTable();

        public static Context.LibraryItemsDataTable GetLibraryItems()
        {
            var dt = new Context.LibraryItemsDataTable();
            LibraryItemAdapter.Fill(dt);

            return dt;
        }

        public static bool SaveLibraryItem(Context.LibraryItemsRow li)
        {
            LibraryItems.AddLibraryItemsRow(li);
            var updateSuccessfull = LibraryItemAdapter.Update(LibraryItems) > 0;

            return updateSuccessfull; // success > 0
        }
    }
}
