namespace Lib
{
    public class Book
    {
        private float discount;
        public string Author { get;}
        public string Title { get;}
        public float Price { get; set;}
        public float Discount 
        { 
            get
            {
                if (discount == 0) 
                {
                    if (Price < 200)
                    {
                        discount = 0;
                    }
                    else if (Price >= 200 && Price < 500)
                    {
                        discount = 10;
                    }
                    else if (Price >= 500 && Price < 1000)
                    {
                        discount = 20;
                    }
                    else if (Price >= 1000)
                    {
                        discount = 25;
                    }
                }
                return discount;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    discount = value;
                }
            }
        }
        public uint PageSize { get; init;}

        public Book(string bookAuthor, string bookTitle)
        {
          Author = bookAuthor;
          Title = bookTitle;
        }

        public void Open()
        {
            Console.WriteLine($"Ви відкрили книгу {Title} автора {Author} за оригінальною ціною {Price} зі знижкою {Discount} відсотків, к-сть сторінок {PageSize}");
            if (this is BookWithImages)
            {
            var book = this as BookWithImages;
            Console.WriteLine($"Ілюстрація {book.ImageCover[0]}");
            }
        }
    }
}
