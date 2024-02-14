namespace Ex18;

internal class Program
{
    private static void Main(string[] args)
    {
        var controlValue = int.Parse(Console.ReadLine());

        var counter = 0;
        string? password = null;
        for (var i = 1; i <= 9; i++)
        for (var j = 1; j <= 9; j++)
        for (var k = 1; k <= 9; k++)
        for (var l = 1; l <= 9; l++)
            if (i < j && k > l)
                if (i * j + k * l == controlValue)
                {
                    Console.Write($"{i}{j}{k}{l} ");
                    counter++;
                    if (counter == 4) password = $"{i}{j}{k}{l}";
                }

        if (counter > 0) Console.WriteLine();
        Console.WriteLine(password != null ? $"Password: {password}" : "No!");
    }
}