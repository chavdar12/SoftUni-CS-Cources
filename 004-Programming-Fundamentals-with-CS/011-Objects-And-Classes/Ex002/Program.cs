using System.Numerics;

namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (var i = 2; i <= n; i++) factorial *= i;

        Console.WriteLine(factorial);
    }
}