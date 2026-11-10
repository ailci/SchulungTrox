namespace _05_Klassen;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Klassen");

        Person p1 = new Person
        {
            Name = "Ich", 
            Email = "test@example.com"
        }; // Object-initializer
        //p1._name = "Ich";
        //p1.Name = "Ich";
        //p1.Email = "test@example.com";
        Console.WriteLine(Person.AnzahlPersonen);

        Person p2 = new Person("BlaBlubb");
        Console.WriteLine(Info.GetAktuellesDatum());

    }
}