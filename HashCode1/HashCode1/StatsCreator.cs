using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode1
{
    public static class StatsCreator
    {
        public static Dictionary<int, List<LibraryStats>> GetStats(int daysLeft, List<Library> libs)
        {
            var result = new Dictionary<int, List<LibraryStats>>();

            for (int i = 0; i < daysLeft; ++i)
            {
                var stats = new List<LibraryStats>();
                var days = i + 1;

                foreach (var l in libs)
                {
                    var books = l.getMaxScoresForDays(days, true);
                    stats.Add(new LibraryStats() { Library = l, Score = books.Select(x => x.score).Sum(), Books = books });
                }

                result.Add(days, stats);
            }

            return result;
        }
    }
}
