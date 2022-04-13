using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.Async
{
    internal class PlayerDataGridChanged
    {
        public ICollection<Player> UpdatedPlayersList { get; set; }

        public uint CurrentPage { get; set; }

        public uint TotalPages { get; set; }

    }
}
