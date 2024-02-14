namespace Ex14;

internal class Program
{
    private static void Main(string[] args)
    {
        var hundredsUpperBorder = int.Parse(Console.ReadLine());
        var dozensUpperBorder = int.Parse(Console.ReadLine());
        var onesUpperBorder = int.Parse(Console.ReadLine());

        for (var i = 1; i <= hundredsUpperBorder; i++)
        for (var j = 1; j <= dozensUpperBorder; j++)
        for (var k = 1; k <= onesUpperBorder; k++)
            if (k % 2 == 0 && i % 2 == 0)
                if (j is 2 or 3 or 5 or 7)
                    Console.WriteLine($"{i} {j} {k}");
    }
}