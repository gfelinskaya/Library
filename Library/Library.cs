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

        public Book this[int index] 
        { 
            get => books[index]; 
        }
        public Book this[string author]
        {
            get
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] != null && books[i].Author == author)
                    {
                        return books[i];
                    }
                }
                return null;
            }
        }

        public void Add (Book book)
        {
            books[index] = book;
            index++;
        }
    }
}