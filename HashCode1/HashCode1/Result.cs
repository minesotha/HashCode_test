using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode1
{
    public class Result
    {
        public int libraryId;
        public int[] scannedBooksIds;

        public Result(int libraryId, int[] scannedBooksIds)
        {
            this.libraryId = libraryId;
            this.scannedBooksIds = scannedBooksIds;
        }

        public string getResultLine()
        {
            string line = $"{libraryId} {scannedBooksIds.Length}\n";
            for (int i = 0; i < scannedBooksIds.Length; i++)
            {
                line += $"{scannedBooksIds[i]}";
            }

            return line;
        }
    }
}
