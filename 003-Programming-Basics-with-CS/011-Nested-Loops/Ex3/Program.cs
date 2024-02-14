namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var combinationsCount = 0;

        for (var i = 0; i <= n; i++)
        for (var j = 0; j <= n; j++)
        for (var k = 0; k <= n; k++)
            if (i + j + k == n)
                combinationsCount++;
        Console.WriteLine(combinationsCount);
    }
}