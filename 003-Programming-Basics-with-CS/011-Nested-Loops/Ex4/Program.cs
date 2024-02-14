namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var start = int.Parse(Console.ReadLine());
        var end = int.Parse(Console.ReadLine());

        const bool isMagicNumberFound = false;
        var magicNumber = int.Parse(Console.ReadLine());
        var comb = 0;

        for (var i = start; i <= end; i++)
        for (var j = start; j <= end; j++)
        {
            comb++;
            if (i + j != magicNumber) continue;
            Console.WriteLine($"Combination N:{comb} ({i} + {j} = {magicNumber})");
            return;
        }

        if (!isMagicNumberFound) Console.WriteLine($"{comb} combinations - neither equals {magicNumber}");
    }
}