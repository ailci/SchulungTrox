/*
 * Aufgabe: Maximum eines Arrays
 *
 * Schreiben Sie eine Methode, die das Maximum eines Arrays von Ganzzahlen zurückgibt.
 *
 * Beispiel:
 * Input: [3, 5, 1]
 * Output: 5
 */
namespace AufgabeMaximumArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] myNumbers = [3, 7, 2, 5, 1];

            //int max = myNumbers.Max();
            //Console.WriteLine(max);

            Array.Sort(myNumbers);
            Console.WriteLine(myNumbers[myNumbers.Length - 1]);
            Console.WriteLine(myNumbers[^1]);
            Console.WriteLine(myNumbers[^2]);
            Console.WriteLine(myNumbers[1..3]);

            int[] neu = [.. myNumbers, 5];
            int[] neu2 = myNumbers[..];
            Console.WriteLine(neu);
            
        }
    }
}
