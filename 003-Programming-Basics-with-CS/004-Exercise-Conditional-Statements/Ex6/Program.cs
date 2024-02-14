namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var movieBudget = double.Parse(Console.ReadLine());
        var workerCount = int.Parse(Console.ReadLine());
        var clothesForOneWorkerPrice = double.Parse(Console.ReadLine());

        var decor = movieBudget * 0.10;
        var clothesTotalPrice = clothesForOneWorkerPrice * workerCount;


        if (workerCount >= 150)
        {
            var discount = clothesTotalPrice * 0.10;
            clothesTotalPrice -= discount;
        }

        var totalPriceForTheMovie = decor + clothesTotalPrice;

        if (movieBudget >= totalPriceForTheMovie)
        {
            var moneyLeft = movieBudget - totalPriceForTheMovie;
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
        }
        else if (totalPriceForTheMovie > movieBudget)
        {
            var moneyNeeded = totalPriceForTheMovie - movieBudget;
            Console.WriteLine($"Not enough money!");
            Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
        }
    }
}