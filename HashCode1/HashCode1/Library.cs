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
            Book[] books = new Book[numberOfBooks];

            //add scores to books

            for (int i = 0; i < numberOfBooks-1; i++)
            {
                books[i] = new Book(_booksIds[i], _boookScores[i]);
            }
        }

        public int getMaxScoresForDays(int _numberOfDays, bool _useSignedStatus)
        {
            return 0;
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
