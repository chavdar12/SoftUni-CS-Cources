namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var tripPrice = double.Parse(Console.ReadLine());
        var puzzlesCount = int.Parse(Console.ReadLine());
        var talkingDollsCount = int.Parse(Console.ReadLine());
        var bearsCount = int.Parse(Console.ReadLine());
        var minionsCount = int.Parse(Console.ReadLine());
        var trucksCount = int.Parse(Console.ReadLine());

        const double puzzlePrice = 2.60;
        const double talkingDollPrice = 3.00;
        const double bearPrice = 4.10;
        const double minionPrice = 8.20;
        const double truckPrice = 2.00;

        var totalPurchasedToys = puzzlesCount + talkingDollsCount + bearsCount + minionsCount + trucksCount;
        var totalSum = puzzlesCount * puzzlePrice + talkingDollsCount * talkingDollPrice + bearsCount * bearPrice +
                       minionsCount * minionPrice + trucksCount * truckPrice;

        if (totalPurchasedToys >= 50)
        {
            var discountPrice = totalSum * 0.25;
            totalSum -= discountPrice;
        }

        var moneyLeftAfterRent = totalSum - totalSum * 0.10; // 10% from totalSum

        if (moneyLeftAfterRent > tripPrice)
        {
            var leftMoney = moneyLeftAfterRent - tripPrice;
            Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
        }
        else if (moneyLeftAfterRent < tripPrice)
        {
            var neededMoney = tripPrice - moneyLeftAfterRent;
            Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
        }
    }
}