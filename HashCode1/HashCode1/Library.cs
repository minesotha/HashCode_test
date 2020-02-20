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
            libraryId = _libraryId;
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

        public List<Book> getMaxScoresForDays(int _numberOfDays, bool _useSignedStatus)
        {
            List<Book> booksToParse = new List<Book>();

            var orderedBooks = books.OrderByDescending(l => l.score).Where(x => !x.isScanned).ToList();
            for (int i = 0; i < _numberOfDays; ++i)
            {
                if (!isSignedIn && signUpDays > i) { continue; }

                var b = GetBooksForDay(orderedBooks);
                foreach (var boo in b)
                {
                    orderedBooks.Remove(boo);
                }
                booksToParse.AddRange(b);
            }

            return booksToParse;
        }

        private List<Book> GetBooksForDay(List<Book> books)
        {
            var r = new List<Book>();

            for (int i = 0; i < booksPerDay; ++i)
            {
                if (books.Count > i)
                {
                    r.Add(books[i]);
                }
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
