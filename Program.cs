public class Addition
{
    public Addition(int a, int b)
    {
        Console.WriteLine($"Result is:{ a + b}");
    }
    public static void Main(string[] args)
    {
        Addition obj = new Addition(1, 2, 3);
    }
}