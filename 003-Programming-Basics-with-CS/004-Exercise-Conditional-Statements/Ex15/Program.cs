namespace Ex15;

internal class Program
{
    private static void Main(string[] args)
    {
        var magnoliasCount = int.Parse(Console.ReadLine());
        var hyacinthsCount = int.Parse(Console.ReadLine());
        var rosesCount = int.Parse(Console.ReadLine());
        var causesCount = int.Parse(Console.ReadLine());

        var giftPrice = double.Parse(Console.ReadLine());

        const double magnoliasPrice = 3.25;
        const double hyacinthsPrice = 4.00;
        const double rosesPrice = 3.50;
        const double cactusesPrice = 8.00;

        var totalSum = magnoliasCount * magnoliasPrice + hyacinthsCount * hyacinthsPrice + rosesCount * rosesPrice +
                       causesCount * cactusesPrice;
        var taxes = totalSum * 0.05;
        var sumAfterTaxes = totalSum - taxes;

        if (sumAfterTaxes >= giftPrice)
        {
            var leftMoney = sumAfterTaxes - giftPrice;
            Console.WriteLine($"She is left with {Math.Floor(leftMoney)} leva.");
        }
        else if (giftPrice > sumAfterTaxes)
        {
            var moneyNeeded = giftPrice - sumAfterTaxes;
            Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyNeeded)} leva.");
        }
    }
}