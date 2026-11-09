namespace _03_BasicTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int age = 28;
            long myLong = 8761438740847; // in C# => 8_761_438_740_847

            //Float
            float temperature = 98.6f; // Grafik, Spiele, Positionen, Geschwindigkeiten, Farben, Koordinaten

            double pi = 3.14159d; // Scientific, graphics
            decimal price = 19.99m; //financial data
            decimal price2 = 29.55m;

            decimal total = decimal.Add(price, price2);

            //String
            string name = "ich";

            //Char
            char test = 'a';

            Console.WriteLine("Hallo ich bin");
            Console.WriteLine("Line 2\n");
            Console.WriteLine("\rLine 2\n");
            Console.WriteLine("C:\\Program Files\\App");
            Console.WriteLine(@"C:\Program Files\App"); // Verbatim-string

            //String
            string message = "Hello" + " World";
            string message2 = $"Hello {message}";
            string message3 = """
                 Hallo ich bins
                 so "kalt" 
                """;
            Console.WriteLine($"hallo {test}");

            //Bool
            bool schnitzel = true;
            bool pommes = false;
            bool salat = true;
            bool essenZuHause = salat || schnitzel && pommes;
            Console.WriteLine($"Essen zu Hause: {essenZuHause}");

            //Var
            var testReloaded = "Hallo";
            testReloaded = "bla blubb";

            //Null
            string? name2 = "Ich";
            string vorname = "";
            string email = name2 ?? "default";

            int? first = null;
            int? second = null;
            int? third = 100;
            int result = first ?? second ?? third ?? 0;

            string nullable = null;
            int safeLength = nullable?.Length ?? 0;

            //Umwandlung
            int grosseZahl = 322; // 0000 0001 0100 0010
            byte kleineZahl = (byte) grosseZahl;
            Console.WriteLine(kleineZahl); // 0100 0010 => 8bit = 66


            string? eingabe = Console.ReadLine();
            Console.WriteLine(eingabe);
        }
    }
}
