using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode1
{
    public class LibraryStats
    {
        public Library Library { get; set; }
        public int Score { get; set; }

        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Library.libraryId, Score);
        }
    }
}
