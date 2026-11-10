using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Klassen;

internal class Person
{
    private static int _anzahlPersonen = 0;
    private string _name;
    public string Name { get; set; } = string.Empty;
    public string? Email { get; set; }

    public static int AnzahlPersonen
    {
        get { return _anzahlPersonen; }
    }

    public Person()
    {
        _name = "Ich";
    }

    public Person(string name)
    {
        _name = name;
    }
}