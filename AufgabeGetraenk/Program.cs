namespace AufgabeGetraenk;

// Hierarchie - Methode Trinken()
// Kaffee, Tee, Wasser, Cola
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("#### Getränke ###");

        Tee t = new Tee(TeeSorte.GruenerTee, "Weisser Sencha", false, 80);
        Coffee coffee = new Coffee(hasCoffein: true, "Nescafe", false, 95);

        Console.WriteLine(t.ToString());

        Trinkhalle trinkhalle = new Trinkhalle();
        trinkhalle.Getraenke.Add(coffee);
        trinkhalle.Getraenke.Add(t);
        trinkhalle.Getraenke.Add(new Cleanser());

        foreach (var liquid in trinkhalle.Getraenke)
        {
            Console.WriteLine(liquid.GetType().Name);
        }

    }
}