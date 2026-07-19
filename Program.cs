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

        #region Task 3

        // Compile-time error,string value can't be assigned directly to an int variable
        int pages = 464;

        #endregion

        #region Task 4

        try
        {
            int f = 10;
            int a = 0;
            int result = f / a;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Done");
        }

        #endregion

        #region Task 5

        int paperpages = 300;
        double number = paperpages;

        Console.WriteLine(number);

        #endregion

        #region Task 6

        double price = 49.99;
        int newPrice = (int)price;

        Console.WriteLine(newPrice);

        #endregion

        #region Task 7
        string pagesText = "464";
        int convertedPages = Convert.ToInt32(pagesText);

        Console.WriteLine(convertedPages);

        #endregion

        #region Task 9
        int bookPages = 464;
        string pageString = bookPages.ToString();

        Console.WriteLine(pageString);
        Console.WriteLine(pageString.GetType());

        #endregion
    }
}
