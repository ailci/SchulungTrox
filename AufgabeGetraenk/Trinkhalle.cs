using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeGetraenk;

public class Trinkhalle<T> where T : IDrink
{
    private T[] drinks = [];

    public T Pop()
    {
        return this.drinks.Last();
    }

    public T[] Push(T drink)
    {
        drinks[drinks.Length] = drink;
        return drinks;
    }
}