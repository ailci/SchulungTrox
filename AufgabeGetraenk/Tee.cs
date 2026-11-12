using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeGetraenk;

public enum TeeSorte
{
    SchwarzerTee,
    GruenerTee
}

public class Tee : Getraenk
{
    public TeeSorte TeeSorte { get; set; }

    public Tee(TeeSorte teeSorte, string name, bool isToxic, int temp)
        : base(name, isToxic, temp)
    {
        TeeSorte = teeSorte;
    }

    public Tee(TeeSorte teeSorte, string name, int temp) : this(teeSorte, name, false, temp)
    { }

    public override string ToString()
    {
        return $"Ich bin Tee";
    }
}