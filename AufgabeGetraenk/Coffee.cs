using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeGetraenk;

public class Coffee : Getraenk
{
    public bool HasCoffein { get; set; }
    public Coffee(bool hasCoffein, string name, bool isToxic, int temp) 
        : base(name, isToxic: isToxic, temperature: temp)
    {
        HasCoffein = hasCoffein;
    }
}