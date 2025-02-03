namespace Lib
{
    internal class Library
    {
        private Book [] books;
        public Library ()
        {
            books = new Book [100];
        }
        
        public void Add (Book book, int index)
        {
            books[index] = book;
        }
    }
}