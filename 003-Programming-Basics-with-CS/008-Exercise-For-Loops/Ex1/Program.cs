namespace Ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        for (var i = 7; i <= 997; i++)
            if (i % 10 == 7)
                Console.WriteLine(i);
    }
}