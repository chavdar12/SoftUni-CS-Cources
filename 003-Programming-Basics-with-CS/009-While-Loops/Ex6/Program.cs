namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var maxNumber = int.MinValue;
        var input = Console.ReadLine();
        while (input != "Stop")
        {
            var numbers = int.Parse(input);
            if (numbers > maxNumber) maxNumber = numbers;
            input = Console.ReadLine();
        }

        Console.WriteLine(maxNumber);
    }
}