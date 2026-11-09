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

            
        }
    }
}
