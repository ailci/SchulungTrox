using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Klassen;

public interface IBier
{
    string HolBier();
}

public class Veltins : IBier
{
    public string HolBier()
    {
        return "Veltins";
    }
}

public class KellerPils : IBier
{
    public string HolBier()
    {
        return "KellerPils";
    }
}
public class DepenInj
{
    private IBier _bier;

    public DepenInj(IBier bier)
    {
        _bier = bier;
    }
}