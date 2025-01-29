namespace Library
{
    internal class Program
    {
        static void Main()
        {
           Book forChildren = new Book("Lebiha", "Boys", 287, 67.7f, 22); 
           Book forMen = new Book("Moroz", "realMen", 567, 98.4f, 34);
           forChildren.Open(); 
           forMen.Open();      
        }
    }
}