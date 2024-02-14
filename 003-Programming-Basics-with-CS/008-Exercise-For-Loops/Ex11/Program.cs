namespace Ex11;

internal class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());

        double totalPoints = 0;

        double percent0To9 = 0;
        double percent10to19 = 0;
        double percent20to29 = 0;
        double percent30to39 = 0;
        double percent40to50 = 0;

        double invalidNumbersPercent = 0;

        for (var i = 0; i < count; i++)
        {
            var numbers = int.Parse(Console.ReadLine());
            if (numbers is >= 0 and <= 50)
            {
                switch (numbers)
                {
                    case >= 0 and <= 9:
                        totalPoints += numbers * 0.20;
                        percent0To9++;
                        break;
                    case >= 10 and <= 19:
                        totalPoints += numbers * 0.30;
                        percent10to19++;
                        break;
                    case >= 20 and <= 29:
                        totalPoints += numbers * 0.40;
                        percent20to29++;
                        break;
                    case >= 30 and <= 39:
                        totalPoints += 50;
                        percent30to39++;
                        break;
                    case >= 40 and <= 50:
                        totalPoints += 100;
                        percent40to50++;
                        break;
                }
            }
            else
            {
                invalidNumbersPercent++;
                totalPoints /= 2;
            }
        }

        Console.WriteLine($"{totalPoints:f2}");
        Console.WriteLine($"From 0 to 9: {percent0To9 / count * 1.00 * 100:f2}%");
        Console.WriteLine($"From 10 to 19: {percent10to19 / count * 1.00 * 100:f2}%");
        Console.WriteLine($"From 20 to 29: {percent20to29 / count * 1.00 * 100:f2}%");
        Console.WriteLine($"From 30 to 39: {percent30to39 / count * 1.00 * 100:f2}%");
        Console.WriteLine($"From 40 to 50: {percent40to50 / count * 1.00 * 100:f2}%");
        Console.WriteLine($"Invalid numbers: {invalidNumbersPercent / count * 1.00 * 100:f2}%");
    }
}