public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        var p = new Program();
        string x = p.Test();
    }

    public string Test()
    {
        return "Test";
    }
}