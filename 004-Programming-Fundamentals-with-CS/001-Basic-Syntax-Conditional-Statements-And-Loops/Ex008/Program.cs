namespace Ex008;

internal class Program
{
    private static void Main(string[] args)
    {
        for (var i = 1; i < 100; i++)
            if (i % 3 == 0)
                Console.WriteLine(i);
    }
}