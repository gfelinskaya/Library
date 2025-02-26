namespace Lib
{
    public class Program
    {
        static void Main()
        {
           Book forChildren = new Book("Lebiha", "Boys") {PageSize = 289};
           forChildren.Price = 23;
           forChildren.Discount = 20;

           Book forMen = new Book("Moroz", "realMen") {PageSize = 456};
           forMen.Price = 78;
           forMen.Discount = 37;

           byte[] images = new byte[] { 65, 66, 67, 68 };
           Book forWomenWithImages = new BookWithImages ("Roll", "Woman", images) {PageSize = 234};
           forMen.Price = 78;
           forMen.Discount = 37;

           forWomenWithImages.Open();

           forChildren.Open(); 

           forMen.Open();   
           
           Library newLibrary = new Library();   
           newLibrary.AddBook(forChildren);
           newLibrary.AddBook(forMen);
        }
    }
}