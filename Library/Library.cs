namespace Lib
{
    class Library
    {
        private int index = 0;
        private Book[] books;
        public Library ()
        {
            books = new Book[100];
        }
        public void Add (Book book)
        {
            books[index] = book;
            index++;
        }
    }
}