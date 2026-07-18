#region Task 1
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
        object myBook = new Book { Title = "WORLD WAR||", Pages = 400 };

        Console.WriteLine(myBook);
    }
}
#endregion