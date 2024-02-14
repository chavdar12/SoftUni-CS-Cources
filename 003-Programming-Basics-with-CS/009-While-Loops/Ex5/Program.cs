namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        double totalSum = 0;
        var input = Console.ReadLine();
        while (input != "NoMoreMoney")
        {
            var moneyIn = double.Parse(input);
            if (moneyIn < 0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }

            Console.WriteLine($"Increase: {moneyIn:f2}");
            totalSum += moneyIn;
            input = Console.ReadLine();
        }

        Console.WriteLine($"Total: {totalSum:f2}");
    }
}