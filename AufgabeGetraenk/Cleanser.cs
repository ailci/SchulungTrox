using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeGetraenk;

public class Cleanser : ILiquid
{
    public string Name { get; set; } = "The Donald";
    public bool IsToxic { get; set; } = true;
}