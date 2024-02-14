namespace Ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        for (var h = 0; h <= 23; h++)
        for (var m = 0; m <= 59; m++)
            Console.WriteLine($"{h}:{m}");
    }
}