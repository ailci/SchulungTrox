using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeGetraenk;

public abstract class Getraenk : IDrink
{
    public string Name { get; set; }
    public bool IsToxic { get; set; }
    public int Temperature { get; set; }

    public Getraenk()
    {}

    public Getraenk(string name, bool isToxic, int temperature)
    {
        Name = name;
        IsToxic = isToxic;
        Temperature = temperature;
    }

    public void Drink()
    {
        Console.WriteLine($"{Name} ## Toxic: {IsToxic} ## Temperature: {Temperature}");
    }
}