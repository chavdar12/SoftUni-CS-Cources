namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        var budget = int.Parse(Console.ReadLine());
        var season = Console.ReadLine();
        var fishermenCount = int.Parse(Console.ReadLine());

        const int shipRentAtSpring = 3000;
        const int shipRentAtAutumnAndSummer = 4200;
        const int shipRentAtWinter = 2600;

        double totalSum = 0;
        double discount;

        totalSum = season switch
        {
            "Spring" => shipRentAtSpring,
            "Summer" => shipRentAtAutumnAndSummer,
            "Autumn" => shipRentAtAutumnAndSummer,
            "Winter" => shipRentAtWinter,
            _ => totalSum
        };

        switch (fishermenCount)
        {
            case <= 6:
                discount = totalSum * 0.10;
                totalSum -= discount;
                break;
            case >= 7 and <= 11:
                discount = totalSum * 0.15;
                totalSum -= discount;
                break;
            case >= 12:
                discount = totalSum * 0.25;
                totalSum -= discount;
                break;
        }

        if (fishermenCount % 2 == 0 && season != "Autumn")
        {
            var discountTwo = totalSum * 0.05;
            totalSum -= discountTwo;
        }

        if (budget >= totalSum)
        {
            var moneyLeft = budget - totalSum;
            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
        }
        else if (totalSum > budget)
        {
            var moneyNeeded = totalSum - budget;
            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
        }
    }
}