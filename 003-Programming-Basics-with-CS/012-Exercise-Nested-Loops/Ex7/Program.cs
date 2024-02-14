namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstNumberUpperBorder = int.Parse(Console.ReadLine());
        var secondNumberUpperBorder = int.Parse(Console.ReadLine());
        var thirdNumberUpperBorder = int.Parse(Console.ReadLine());

        for (var i = 1; i <= firstNumberUpperBorder; i++)
        for (var j = 1; j <= secondNumberUpperBorder; j++)
        for (var k = 1; k <= thirdNumberUpperBorder; k++)
            if (i % 2 == 0 && k % 2 == 0 &&
                j is 2 or 3 or 5 or 7)
                Console.WriteLine($"{i} {j} {k}");
    }
}