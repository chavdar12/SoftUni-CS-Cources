namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        for (var first = 1; first <= 10; first++)
        for (var second = 1; second <= 10; second++)
            Console.WriteLine($"{first} * {second} = {first * second}");
    }
}