namespace _06_Vererbung;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vererbung");

        //Fahrzeug fahrzeug = new Fahrzeug("KLE-159");
        //fahrzeug.Fahren();

        Pkw p1 = new Pkw("GE-AI-137");
        p1.Fahren();
        p1.Bremsen();
        Console.WriteLine(p1.ToString());

        //Polymorphism
        Fahrzeug fahrzeug = new Lkw("Blabubb", 6);

        IBremsable bremsable = new Lkw("dfgdf",6);
        bremsable.Bremsen();

    }

    static void FahrzeugInfo(Fahrzeug fahrzeug)
    {

    }
}
