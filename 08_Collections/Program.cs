using Util;

namespace _08_Collections;

internal class Program
{
    static void Main(string[] args)
    {
        ColorConsole.WriteWrappedHeader("Collections");

        List<int> numbers = new List<int>();
        List<string> fruits = new List<string> { "Apfel, Banane, Orange"};
        List<string> fruits2 = ["Apfel, Banane, Orange"];
        var fruits3 = new List<string> { "Melone", "Kirsche" };

        foreach (var fruit in fruits3)
        {
            Console.WriteLine(fruit);
        }

        fruits3.Add("Zitrone");
        fruits3.Remove("Zitrone");

        List<int> myNumbers = [4, 8, 1, 3];
        numbers.Sort();

        //Dictionary
        Dictionary<string, int> prices = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 }
        };
         //Alternative ab C# 6
        Dictionary<string, int> prices2 = new Dictionary<string, int>
        {
           ["Alice"] = 25,
           ["Bob"] = 30
        };
        prices2.Add("John", 40);
        bool existAlice = prices2.ContainsKey("Alice");

        if (prices2.TryGetValue("Alice", out int age))
        {

        }



        try
        {
            int zahl = int.Parse("eingabe");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    static void GetInfo(string? message)
    {
        //Langversion
        if (message is null) throw new ArgumentNullException("message is null");

        //Tobias Favorite Kurzversion
        ArgumentNullException.ThrowIfNull(message);
    }
}