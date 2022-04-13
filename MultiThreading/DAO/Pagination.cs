using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.DAO
{
    internal class Pagination
    {
        internal UInt32 CurrentPage { get; private set; }

        internal UInt32 TotalPages { get; private set; }

        internal UInt32 ItemsPerPage { get; private set; }

        internal UInt32 TotalNumberOfItems { get; private set; }

        public Pagination(UInt32 itemsPerPage, UInt32 totalNumberOfItems)
        {
            //Data assertions
            Debug.Assert(itemsPerPage > 0);

            CurrentPage = 1;
            ItemsPerPage = itemsPerPage;
            TotalNumberOfItems = totalNumberOfItems;
            TotalPages = (uint)Math.Ceiling((double)totalNumberOfItems / itemsPerPage);
        }

        public bool PreviousPage()
        {

            if (CurrentPage <= 1) return false;

            CurrentPage--;

            return true;
        }

        public bool NextPage()
        {
            if (CurrentPage >= TotalPages) return false;

            CurrentPage++;

            return true;
        }

        public bool HasDataToFetch() => TotalNumberOfItems > 0;

        public int CurrentPercentage() => (int) ((double) CurrentPage / TotalPages * 100);

        public uint InitialSkipValue() => (CurrentPage - 1) * ItemsPerPage;

    }
}
