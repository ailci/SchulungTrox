using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeGetraenk;

public interface IDrink : ILiquid
{
    int Temperature { get; set; }
    void Drink();
}