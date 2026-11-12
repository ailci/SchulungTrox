namespace _09_Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LinQ");

        //Beispiel
        int[] numbers = [5, 7, 4, 2, 8, 6];
        var lowNumbers = from n in numbers
            where n < 5
            orderby n descending
            select n;

        //foreach (var lowNumber in lowNumbers)
        //{
        //    Console.WriteLine(lowNumber);
        //}

        //Person
        List<Person> personen =
        [
            new() { Vorname = "Eddie", Name = "Kies", Alter = 65},
            new() { Vorname = "Phil", Name = "Fries", Alter = 31},
            new() { Vorname = "Rachid", Name = "Meister", Alter = 47},
            new() { Vorname = "Jonas", Name = "MrRich", Alter = 31},
        ];

        var query = from person in personen
            where person.Alter > 40 && person.Name == "Meister"
            select person;

        foreach (Person person in query)
        {
            Console.WriteLine(person.Name);
        }

        Kunde k = new Kunde("Bla");
        
    }
}