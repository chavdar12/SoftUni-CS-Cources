namespace Ex15;

internal class Program
{
    private static void Main(string[] args)
    {
        var start = int.Parse(Console.ReadLine());
        var end = int.Parse(Console.ReadLine());
        var magicNumber = int.Parse(Console.ReadLine());

        var flag = false;
        var combinationCounter = 0;

        for (var i = start; i <= end; i++)
        {
            for (var j = start; j <= end; j++)
            {
                combinationCounter++;
                if (i + j != magicNumber) continue;
                flag = true;
                Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNumber})");
                break;
            }

            if (flag) break;
        }

        if (flag == false) Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
    }
}