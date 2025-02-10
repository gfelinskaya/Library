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

           forChildren.Open(); 

           forMen.Open();   
           
           Library newLibrary = new Library();   
           newLibrary.Add(forChildren);
           newLibrary.Add(forMen);
        }
    }
}