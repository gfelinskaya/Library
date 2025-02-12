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
        public void AddBook (Book book)
        {
            books[index] = book;
            index++;
            BubbleSortByFirstLetterOfAuthor();
        }
         public void AddBook (BookWithImages book)
        {
            books[index] = book;
            index++;
            BubbleSortByFirstLetterOfAuthor();
        }
        private void BubbleSortByFirstLetterOfAuthor()
        {
            // Алгоритм бульбашки для сортування
            for (int i = 0; i < index - 1; i++)  // Зовнішній цикл проходить по всіх елементах
            {
                for (int j = 0; j < index - i - 1; j++)  // Внутрішній цикл для порівняння сусідніх елементів
                {
                    // Якщо перша літера автора книги на позиції j більша за першу літеру на позиції j+1, міняємо їх місцями
                    if (string.Compare(books[j].Author[0].ToString(), books[j + 1].Author[0].ToString()) > 0)
                    {
                        // Обмін місцями
                        Book temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }
        }
    }
}