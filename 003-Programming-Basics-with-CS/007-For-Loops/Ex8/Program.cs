namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        var maxNumber = int.MinValue;
        var minNumber = int.MaxValue;

        for (var i = 0; i < number; i++)
        {
            var numbers = int.Parse(Console.ReadLine());
            if (numbers > maxNumber) maxNumber = numbers;
            if (numbers < minNumber) minNumber = numbers;
        }

        Console.WriteLine($"Max number: {maxNumber}");
        Console.WriteLine($"Min number: {minNumber}");
    }
}