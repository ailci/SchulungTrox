namespace _10_ExtensionMethods;

public class Program
{
    static void Main(string[] args)
    {
        string test = "Dies ist ein test für Erweiterungsmethoden";
        Console.WriteLine(test.WordCount());
    }
}

public static class StringExtensions
{
    extension(string s)
    {
        public int WordCount()
        {
            return s.Split([' ', '.', '?'], StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public string UpperCaseLetters(int letterCount = 1)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;

            char[] chars = s.ToCharArray();
            for (int i = 0; i < letterCount && i < s.Length; i++)
                chars[i] = char.ToUpper(chars[i]);
            return new string(chars);
        }
    }
}