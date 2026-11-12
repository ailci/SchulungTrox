using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Vererbung;

//Ein Interface definiert einen Vertrag, den Klassen einhalten müssen. Es legt fest, was eine Klasse tun muss, aber nicht, wie sie es tut.
//Verwenden Sie Interfaces, wenn Sie möchten, dass nicht verwandte Klassen gemeinsames Verhalten teilen.
public interface IBremsable
{
    void Bremsen();
}