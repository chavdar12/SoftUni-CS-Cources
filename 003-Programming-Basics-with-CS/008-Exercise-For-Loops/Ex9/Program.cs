namespace Ex9;

internal class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());

        double busPercent = 0;
        double truckPercent = 0;
        double trainPercent = 0;
        var totalTons = 0;
        double totalSum = 0;

        for (var i = 0; i < count; i++)
        {
            var tons = int.Parse(Console.ReadLine());
            switch (tons)
            {
                case <= 3:
                    busPercent += tons;
                    totalSum += 200 * tons;
                    break;
                case >= 4 and <= 11:
                    truckPercent += tons;
                    totalSum += 175 * tons;
                    break;
                case >= 12:
                    trainPercent += tons;
                    totalSum += 120 * tons;
                    break;
            }

            totalTons += tons;
        }

        Console.WriteLine($"{totalSum / totalTons:f2}");
        Console.WriteLine($"{busPercent / totalTons * 100:f2}%");
        Console.WriteLine($"{truckPercent / totalTons * 100:f2}%");
        Console.WriteLine($"{trainPercent / totalTons * 100:f2}%");
    }
}