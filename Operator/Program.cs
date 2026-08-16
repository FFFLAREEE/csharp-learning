namespace CSharpHelloWorld;

class Program
{
    static int Foo()
    {
        bool b = true;
        return b ? 1 : 2;
    }

    static void Main()
    {
        Console.WriteLine(Foo());
    }
}