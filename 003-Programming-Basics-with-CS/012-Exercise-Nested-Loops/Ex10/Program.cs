namespace Ex10;

internal class Program
{
    private static void Main(string[] args)
    {
        var start = int.Parse(Console.ReadLine());
        var end = int.Parse(Console.ReadLine());

        for (var i = start; i <= end; i++)
        for (var j = start; j <= end; j++)
        for (var k = start; k <= end; k++)
        for (var l = start; l <= end; l++)
            if (((i % 2 == 0 && l % 2 != 0) || (i % 2 != 0 && l % 2 == 0)) && i > l && (j + k) % 2 == 0)
                Console.Write($"{i}{j}{k}{l} ");
    }
}