namespace Ex14;

internal class Program
{
    private static void Main(string[] args)
    {
        var daysOutCount = int.Parse(Console.ReadLine());
        var leftFoodInKg = int.Parse(Console.ReadLine());
        var dogFoodInKgPerDay = double.Parse(Console.ReadLine());
        var catFoodInKgPerDay = double.Parse(Console.ReadLine());
        var turtleFoodInGrPerDay = double.Parse(Console.ReadLine());

        var foodForDog = daysOutCount * dogFoodInKgPerDay;
        var foodForCat = daysOutCount * catFoodInKgPerDay;
        var foodForTurtle = daysOutCount * (turtleFoodInGrPerDay / 1000);

        var totalFoodNeeded = foodForDog + foodForCat + foodForTurtle;

        if (totalFoodNeeded <= leftFoodInKg)
        {
            var foodLeft = leftFoodInKg - totalFoodNeeded;
            Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
        }
        else if (leftFoodInKg < totalFoodNeeded)
        {
            var foodNeeded = totalFoodNeeded - leftFoodInKg;
            Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
        }
    }
}