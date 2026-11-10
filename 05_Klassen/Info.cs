using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Klassen
{
    public static class Info
    {
        public static DateTime LastDatum;

        public static string GetAktuellesDatum()
        {
            LastDatum = DateTime.Now;
            return LastDatum.ToShortDateString();
        }
    }
}
