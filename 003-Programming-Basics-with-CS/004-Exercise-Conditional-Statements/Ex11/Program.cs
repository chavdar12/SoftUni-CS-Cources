namespace Ex11;

internal class Program
{
    private static void Main(string[] args)
    {
        var vineYardInQuadMeters = int.Parse(Console.ReadLine());
        var grapesForOneQuadMeter = double.Parse(Console.ReadLine());
        var wineNeeded = int.Parse(Console.ReadLine());
        var workersCount = int.Parse(Console.ReadLine());

        var totalGrape = vineYardInQuadMeters * grapesForOneQuadMeter;
        var wine = 0.40 * totalGrape / 2.5;

        if (wine >= wineNeeded)
        {
            var wineLeft = wine - wineNeeded;
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
            Console.WriteLine(
                $"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / workersCount)} liters per person.");
        }
        else if (wine < wineNeeded)
        {
            var wineThatNeeded = wineNeeded - wine;
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineThatNeeded)} liters wine needed.");
        }
    }
}