namespace Lib
{
    public class BookWithImages : Book
    {
        
         public byte [] ImageCover { get; set; }

        public BookWithImages(string bookAuthor, string bookTitle, byte [] images) : base(bookAuthor, bookTitle)
        {
            ImageCover=images;
        }
    }
}