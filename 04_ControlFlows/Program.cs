namespace _04_ControlFlows;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Control");
        IfElsePatterMatching();
    }

    static void IfElsePatterMatching()
    {
        int number = 4;

        if(number is 1 or 2 or (3 and not 4))
        {
            Console.WriteLine("is größer");
        }

        if(number is > 0 and < 20)
        {
            Console.WriteLine("Between 1 ánd 9");
        }

        if(number is not > 0)
        {
            Console.WriteLine("Zero or negative");
        }
    }

    static string SwitchExpressionExample()
    {
        int score = 10;

        switch (score) 
        {
            case 10: return "A++";
            case 9: return "A+";
            default: return "B+";
        }

        return score switch
        {
            10 => "A++",
            9 => "A+",
            _ => "B+",
        };
    }
}
