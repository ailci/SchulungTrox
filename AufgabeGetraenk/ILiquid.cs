using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeGetraenk;

public interface ILiquid
{
    string Name { get; set; }    
    public bool IsToxic { get; set; }
}