namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        for (var i = 1; i <= 9; i++)
        for (var j = 1; j <= 9; j++)
        for (var k = 1; k <= 9; k++)
        for (var l = 1; l <= 9; l++)
            if (number % i == 0 &&
                number % j == 0 &&
                number % k == 0 &&
                number % l == 0)
                Console.Write($"{i}{j}{k}{l} ");
    }
}