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
           

           Book firstBook = newLibrary[0];
           Book secondBook = newLibrary[1];
           Book morozBook = newLibrary["Moroz"];
           Book fakeBook = newLibrary["Fake"];
Console.WriteLine($"First book {firstBook.Title}");
Console.WriteLine($"S3econd book {secondBook.Title}");
Console.WriteLine($"morozBook {morozBook.Title}");
Console.WriteLine($"fakeBook {fakeBook.Title}");
        }
    }
}