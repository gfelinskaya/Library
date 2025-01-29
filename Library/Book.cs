using Microsoft.VisualBasic;

namespace Library
{
    internal class Book
    {
        string author;
        string title;
        float price;
        float discount;
        uint pageSize;

        public string Author { get => author;}
        public string Title { get => title;}
        public float Price { get => price; set => price = value; }
        public float Discount { get => discount; set => discount = value; }
        public uint PageSize { get => pageSize;}
        public Book(string bookAuthor, string bookTitle, uint bookPageSize, float bookPrice, float bookDiscount)
        {
          author = bookAuthor;
          title = bookTitle;
          pageSize = bookPageSize;
          price = bookPrice;
          discount = bookDiscount;
        }
        public void Open()
        {
            Console.WriteLine($"Ви відкрили книгу {Title} автора {Author} за оригінальною ціною {Price} зі знижкою {Discount} відсотків, к-сть сторінок {PageSize}");
        }
    }
}