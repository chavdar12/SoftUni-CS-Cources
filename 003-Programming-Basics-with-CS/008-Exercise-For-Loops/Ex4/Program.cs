namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var counter = int.Parse(Console.ReadLine());

        double lessThan200Percent = 0;
        double from200To399Percent = 0;
        double from400To599Percent = 0;
        double from600To799Percent = 0;
        double above800Percent = 0;

        for (var i = 1; i <= counter; i++)
        {
            var numbers = double.Parse(Console.ReadLine());
            switch (numbers)
            {
                case < 200:
                    lessThan200Percent++;
                    break;
                case >= 200 and <= 399:
                    from200To399Percent++;
                    break;
                case >= 400 and <= 599:
                    from400To599Percent++;
                    break;
                case >= 600 and <= 799:
                    from600To799Percent++;
                    break;
                case >= 800:
                    above800Percent++;
                    break;
            }
        }

        Console.WriteLine($"{lessThan200Percent / counter * 1.00 * 100:f2}%");
        Console.WriteLine($"{from200To399Percent / counter * 1.00 * 100:f2}%");
        Console.WriteLine($"{from400To599Percent / counter * 1.00 * 100:f2}%");
        Console.WriteLine($"{from600To799Percent / counter * 1.00 * 100:f2}%");
        Console.WriteLine($"{above800Percent / counter * 1.00 * 100:f2}%");
    }
}