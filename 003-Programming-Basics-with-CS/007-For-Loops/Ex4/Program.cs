namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        for (var i = 0; i <= number; i += 2) Console.WriteLine(Math.Pow(2, i));
    }
}