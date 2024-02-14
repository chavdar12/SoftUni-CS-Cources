namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        for (var i = number; i >= 1; i--) Console.WriteLine(i);
    }
}