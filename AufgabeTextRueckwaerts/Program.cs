/* 1. Aufgabe: Text rückwärts
 * Schreiben Sie ein Programm, das einen Text von der Konsole einliest und diesen 
 * Text rückwärts ausgibt.
 * Beispiel: "Hallo Welt" -> "tleW ollaH"
 */

namespace AufgabeTextRueckwaerts;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie einen Text ein:");

        //string text = ReverseFunktion(Console.ReadLine());
        //Console.WriteLine(text);

        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            return;
        }

        string output = string.Empty;
        for (int i = input.Length; i > 0; i--)
        {
            output += input[i - 1];
        }
        Console.WriteLine(output);
        Console.ReadLine();
    }

    static string ReverseFunktion(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
