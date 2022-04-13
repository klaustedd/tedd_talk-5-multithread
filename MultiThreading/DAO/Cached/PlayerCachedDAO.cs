using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.DAO.Cached
{
    internal class PlayerCachedDAO : IPlayerDAO
    {
        /// <summary>
        /// The database cached in memory
        /// </summary>
        private IList<Player> _database;

        internal PlayerCachedDAO()
        {
            LoadFromCSV();
        }

        private void LoadFromCSV()
        {
            var lines = Resources.mlb_players.Split('\n');
            var linesEnumerator = lines.GetEnumerator();
            var documentDecimalParsingCulture = CultureInfo.GetCultureInfo("en-US");

            _database = new List<Player>(lines.Length);

            //Skip the header
            Debug.Assert(linesEnumerator.MoveNext());

            while (linesEnumerator.MoveNext()) {
                var currentLine = (string) linesEnumerator.Current;
                var splittedCurrentLine = currentLine.Split(',');

                //Assert that the current line has 6 elements
                //Debug.Assert(splittedCurrentLine.Length == 6);
                if (splittedCurrentLine.Length < 5) continue;

                var player = new Player();
                player.Name =       splittedCurrentLine[0].Replace("\"", "").Trim();
                player.Team =       splittedCurrentLine[1].Replace("\"", "").Trim();
                player.Position =   splittedCurrentLine[2].Replace("\"", "").Trim();
                player.Height =     Double.Parse(splittedCurrentLine[3].Trim(), documentDecimalParsingCulture);
                player.Weight = TryParseOrNull(splittedCurrentLine[4].Trim(), documentDecimalParsingCulture);

                _database.Add(player);
            }

            Console.WriteLine($"Loaded {_database.Count} records from the database");
        }

        private double? TryParseOrNull(string v, CultureInfo c)
        {
            try
            {
                return Double.Parse(v, c);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ICollection<Player> GetAll()
        {
            return _database;
        }

        public Pagination PaginationOfAll(UInt32 itemsPerPage)
        {
            return new Pagination(itemsPerPage, (uint) _database.Count);
        }

        public ICollection<Player> GetAll(Pagination pagination)
        {
            var queriedItems = new List<Player>((int) pagination.ItemsPerPage);
            var start = pagination.InitialSkipValue();
            for (uint i = start; i < pagination.ItemsPerPage + start && i < _database.Count ; i++)
            {
                queriedItems.Add(_database[(int) i]);
            }

            return queriedItems;
        }
    }
}
