using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.Models
{
    internal class Player
    {
        /// <summary>
        /// The name of the player.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The player's team
        /// </summary>
        public string Team { get; set; }

        /// <summary>
        /// The position where the player plays
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// The player's height (in inches).
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// The player's weight (in lbs)
        /// </summary>
        public double? Weight { get; set; }
    }
}
