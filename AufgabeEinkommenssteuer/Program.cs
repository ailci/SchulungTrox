/* Aufgabe: Einkommensteuerrechner (Deutschland, Stand 2026)
 * 
 * Berechnen Sie die Einkommensteuer für ein gegebenes Bruttojahreseinkommen in Deutschland für das Jahr 2026.
 * Berücksichtigen Sie dabei die folgenden Steuersätze und Freibeträge:
 * 
 * - Grundfreibetrag: 12.348 EUR
 * - Einkommen bis 12.348 EUR: 0% Steuersatz
 * - Einkommen von 12.349 EUR bis 17.799 EUR: Progressiver Steuersatz von 14% bis 24%
 * - Einkommen von 17.800 EUR bis 69.878 EUR: Progressiver Steuersatz von 24% bis 42%
 * - Einkommen von 69.879 EUR bis 277.825 EUR: Steuersatz von 42%
 * - Einkommen über 277.826 EUR: Steuersatz von 45%
 *
 * Berechnen Sie zusätzlich den Solidaritätszuschlag (5,5% der Einkommensteuer) und die durchschnittliche Steuerbelastung (Einkommensteuer / Bruttoeinkommen).
 * Est > 20350 zahlt man die 5,5%
 */

using System.Globalization;

namespace AufgabeEinkommenssteuer;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Einkommenssteuerrechner (Deutschland, Stand 2026)");
        Console.Write("Bitte geben Sie Ihr Bruttojahreseinkommen (in EURO) ein: ");

        if (decimal.TryParse(Console.ReadLine(), out decimal bruttoEinkommen))
        {
            // Grundfreibetrag für 2026
            decimal grundfreibetrag = 12348;
            decimal est = 0;

            if (bruttoEinkommen <= grundfreibetrag)
            {
                est = 0; // Keine Steuerschuld, wenn das Einkommen den Freibetrag nicht übersteigt.
            }

            if (bruttoEinkommen is >= 12349.0m and <= 17799.0m)
            {
                var y = (bruttoEinkommen - grundfreibetrag) / 10000.0m;
                est = (914.51m * y + 1400.0m) * y;
            }

            if (bruttoEinkommen is >= 17800.0m and <= 69878.0m)
            {
                var z = (bruttoEinkommen - 17799.0m) / 10000.0m;
                est = (173.1m * z + 2397.0m) * z + 1034.87m;
            }

            if (bruttoEinkommen is >= 69879.0m and <= 277825.0m)
            {
                est = 0.42m * bruttoEinkommen - 11135.63m; // 42% Steuersatz
            }

            if (bruttoEinkommen >= 277826)
            {
                est = 0.45m * bruttoEinkommen - 19470.38m; // 45% Steuersatz
            }


            decimal soli = est > 20350 ? (est * 0.055m) : 0.0m;
            // Ausgabe der Ergebnisse
            Console.WriteLine($"\n\nErgebnis #####################################################");
            //Console.WriteLine($"\nGrundfreibetrag: {grundfreibetrag:C}");
            Console.WriteLine($"                     Bruttoeinkommmen: {bruttoEinkommen:C}");
            //Console.WriteLine($"Geschätzte Einkommensteuer: {Math.Ceiling(est).ToString("C")}");
            Console.WriteLine($"                      Einkommensteuer: {est:C}");
            Console.WriteLine($"                 Solidaritätszuschlag: {soli.ToString("C", CultureInfo.GetCultureInfo("de-DE"))}");
            
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
        }
    }
}
