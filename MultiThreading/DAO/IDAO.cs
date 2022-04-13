using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.DAO
{
    internal interface IDAO<T>
    {
        /// <summary>
        /// Fetch all data from the database
        /// </summary>
        /// <returns></returns>
        public ICollection<T> GetAll();

        /// <summary>
        /// Fetch all data from the database using an pagination to limit the queried data
        /// </summary>
        /// <param name="pagination"></param>
        /// <returns></returns>
        public ICollection<T> GetAll(Pagination pagination);

        /// <summary>
        /// Return a pagination of all databa stored in the database
        /// </summary>
        /// <returns></returns>
        /// <param name="itemsPerPage">The quantity of items per page</param>
        public Pagination PaginationOfAll(UInt32 itemsPerPage);
    }
}
