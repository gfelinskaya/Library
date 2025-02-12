namespace Lib
{
    public class BookWithImages : Book
    {
        
         public byte [] Images { get; set; }

        public BookWithImages(string bookAuthor, string bookTitle, byte [] images) : base(bookAuthor, bookTitle)
        {
            Images=images;
        }
    }
}