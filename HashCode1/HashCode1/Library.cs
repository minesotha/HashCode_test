using System.Collections.Generic;
using System.Linq;

namespace HashCode1
{
    public class Library
    {
        public int libraryId = 0;
        public bool isSignedIn = false;
        public int numberOfBooks = 0;
        public int signUpDays = 0;
        public int booksPerDay = 0;
        public Book[] books;
        public Library(int _libraryId, int _numberOfBooks, int _signUpDays, int _booksPerDay, int[] _booksIds, int[] _boookScores)
        {
            numberOfBooks = _numberOfBooks;
            signUpDays = _signUpDays;
            booksPerDay = _booksPerDay;
            books = new Book[numberOfBooks];

            //add scores to books

            for (int i = 0; i < numberOfBooks; i++)
            {
                books[i] = new Book(_booksIds[i], _boookScores[_booksIds[i]]);
            }
        }

        public int getMaxScoresForDays(int _numberOfDays, bool _useSignedStatus)
        {
            var orderedBooks = books.OrderBy(l => l.score).ToList();
            var b = GetBooksForDay(orderedBooks);

            return b.Select(x => x.score).Sum();
        }

        private List<Book> GetBooksForDay(List<Book> books)
        {
            var r = new List<Book>();

            for (int i = 0; i < booksPerDay; ++i)
            {
                r.Add(books[i]);
            }

            return r;
        }
    }

    public class Book
    {
        public int id = 0;
        public int score = 0;
        public bool isScanned = false;

        public Book(int _id, int _score)
        {
            id = _id;
            score = _score;
        }
    }



}
