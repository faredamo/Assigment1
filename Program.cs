using System;
class Book
{
    public string Title;
    public int Pages;
    public override string ToString()
    {
        return $"Title:{Title}, Pages:{Pages}";
    }
}
class Program
{
    static void Main()
    {
        #region Task 1

        object myBook = new Book
        {
            Title = "WORLD WAR II",
            Pages = 400
        };

        Console.WriteLine(myBook);

        #endregion

        #region Task 2

        Console.WriteLine(myBook.ToString());
        Console.WriteLine(myBook.Equals(myBook));
        Console.WriteLine(myBook.GetHashCode());
        Console.WriteLine(myBook.GetType());

        #endregion
    }
}