namespace _04_WerteRefTypes;

internal class Program
{
    static void Main(string[] args)
    {
        //ValueTypesMain();

        Auto a1 = new Auto { Model = "Porsche" };
        Auto a2 = new Auto { Model = "Volvo" };

        Console.WriteLine(a1 == a2 ? "Autos gleich" : "Autos ungleich");

        a2 = a1;

        Console.WriteLine(a1 == a2 ? "Autos gleich NACH" : "Autos ungleich NACH");

        a2.Model = "Opel";

        Console.WriteLine($"Model a1 => {a1.Model}");
        Console.WriteLine($"Model a2 => {a2.Model}");

    }

    #region Value/Ref
    static void ValueTypesMain()
    {
        int zahl = 5;
        Console.WriteLine($"Vor Methodenaufruf: zahl = {zahl}");

        ChangeValue(ref zahl);

        Console.WriteLine($"Nach Methodenaufruf: zahl = {zahl}");

        int weiterZahl = zahl;

        Console.WriteLine($"WeitereZahl = {weiterZahl}");

        weiterZahl = 9;

        Console.WriteLine($"Nach WeiterZahl Änderung: zahl = {zahl}");
    }

    private static void ChangeValue(ref int zahl)
    {
        Console.WriteLine($"In Change Vor Änderung: zahl = {zahl}");
        zahl = zahl + 1;
        Console.WriteLine($"In Change Nach Änderung: zahl = {zahl}");

    }
    #endregion
}

class Auto
{
    public string Model { get; set; }
}
