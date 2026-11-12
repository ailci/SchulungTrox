using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Linq;

public class Person
{
    public required string Name { get; set; }
    public string Vorname { get; set; }
    public int Alter { get; set; }
}

public class Kunde(string name) //Primärkonstruktor
{
    void Print()
    {
        Console.WriteLine(name);
    }
}