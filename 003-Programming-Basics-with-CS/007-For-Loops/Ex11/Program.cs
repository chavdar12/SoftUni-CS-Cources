namespace Ex11;

internal class Program
{
    private static void Main(string[] args)
    {
        var age = int.Parse(Console.ReadLine());
        var priceLaundryMachine = double.Parse(Console.ReadLine());
        var toysPrice = double.Parse(Console.ReadLine());


        double ageMoney = 10;
        double toysCount = 0;
        double totalSavings = 0;

        for (var i = 1; i <= age; i++)
            if (i % 2 == 0)
            {
                totalSavings += ageMoney - 1;
                ageMoney += 10;
            }
            else
            {
                toysCount++;
            }

        totalSavings += toysCount * toysPrice;
        if (totalSavings >= priceLaundryMachine)
        {
            var moneyLeft = totalSavings - priceLaundryMachine;
            Console.WriteLine($"Yes! {moneyLeft:f2}");
        }
        else if (priceLaundryMachine > totalSavings)
        {
            var moneyNeeded = priceLaundryMachine - totalSavings;
            Console.WriteLine($"No! {moneyNeeded:f2}");
        }
    }
}