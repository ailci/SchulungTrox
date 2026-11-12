namespace _07_Generics;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Generics");

        MyStack myStack = new MyStack(10);
        myStack.Push(4);
        myStack.Push("test");

        string stringItem = (string)myStack.Pop();
        int intItem = (int)myStack.Pop();

        //Mit Generics
        MyStack<int> intStack = new MyStack<int>(10);
        intStack.Push(5);
        var eintrag = intStack.Pop();

        MyStack<string> stringStack = new MyStack<string>(10);
        stringStack.Push("hallo");
    }
}