using System.Threading.Channels;

namespace _11_Funcs;

internal class Program
{
    //1.Version Delegate
    //delegate string ConvertMethode(string input);

    //static void Main(string[] args)
    //{
    //    ConvertMethode convert = MakeUpperCase;
    //    string name = "ali";
    //    Console.WriteLine(convert(name)); //Delegate aufgerufen bzw. Methode

    //    Console.ReadLine();
    //}

    //2. Version Func
    //static void Main(string[] args)
    //{
    //    Func<string,string> convert = MakeUpperCase;
    //    string name = "ali";
    //    Console.WriteLine(convert(name)); //Delegate aufgerufen bzw. Methode

    //    Console.ReadLine();
    //}

    //3. Version Anonyme Function
    //static void Main(string[] args)
    //{
    //    Func<string, string> convert = delegate(string input)
    //    {
    //        return input.ToUpper();
    //    };
    //    string name = "ali";
    //    Console.WriteLine(convert(name)); //Delegate aufgerufen bzw. Methode

    //    Console.ReadLine();
    //}

    //4. Lamda Expression
    static void Main(string[] args)
    {
        Func<string, string> convert = input => input.ToUpper();
        Func<string, bool> predicate = input => input == "Ali";
        Action<string> act = input => Console.WriteLine(input);
        string name = "ali";
        Console.WriteLine(convert(name)); //Delegate aufgerufen bzw. Methode
        act(name);
        Console.ReadLine();
    }

    static string MakeUpperCase(string input)
    {
        return input.ToUpper();
    }

    
}