namespace Ex16;

internal class Program
{
    private static void Main(string[] args)
    {
        var oneMonetsCount = int.Parse(Console.ReadLine());
        var twoMonetsCount = int.Parse(Console.ReadLine());
        var fiveBucksCount = int.Parse(Console.ReadLine());
        var sum = int.Parse(Console.ReadLine());

        for (var i = 0; i <= oneMonetsCount; i++)
        for (var j = 0; j <= twoMonetsCount; j++)
        for (var k = 0; k <= fiveBucksCount; k++)
            if (i * 1 + j * 2 + k * 5 == sum)
                Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
    }
}