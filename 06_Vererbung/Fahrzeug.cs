using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Vererbung;

public abstract class Fahrzeug : IBremsable
{
    protected string Kennzeichen { get; set; }
    public abstract int Achsen { get; set; }

    public Fahrzeug()
    {}

    public Fahrzeug(string kennzeichen)
    {
        Kennzeichen = kennzeichen;
    }

    public virtual void Fahren()
    {
        Console.WriteLine("Starte Fahrzeug und los...");
    }

    public override string ToString()
    {
        return $"Kenzeichen: {Kennzeichen}";
    }

    public void Bremsen()
    {
        Console.WriteLine("Bremsen...");
    }
}

public class Pkw : Fahrzeug
{
    public override int Achsen { get; set; } = 2;

    public Pkw(string kennzeichen) : base(kennzeichen)
    {
        //Kennzeichen = kennzeichen;
    }

    public override void Fahren()
    {
        Console.WriteLine("Starte Pkw und los...");
    }

    public override string ToString()
    {
        return $"Kenzeichen: {Kennzeichen} und Achsen: {Achsen}";
    }
}

public class Lkw : Fahrzeug
{
    public override int Achsen { get; set; }
    public string Bezeichnung { get; set; }

    public Lkw(string kennzeichen, int anzahlAchsen) : base(kennzeichen)
    {
        Achsen = anzahlAchsen;    
    }

    public override void Fahren()
    {
        Console.WriteLine("Starte Lkw und los...");
    }
}

public class Loewe : IBremsable
{
    public void Bremsen()
    {
        Console.WriteLine("Lecker Antilope...");
    }
}