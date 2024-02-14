namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var budget = double.Parse(Console.ReadLine());
        var season = Console.ReadLine();

        var destination = string.Empty;
        double totalSum = 0;

        switch (budget)
        {
            case <= 100:
            {
                destination = "Bulgaria";
                totalSum = season switch
                {
                    "summer" => budget * 0.30,
                    "winter" => budget * 0.70,
                    _ => totalSum
                };
                break;
            }
            case <= 1000 and > 100:
            {
                destination = "Balkans";
                totalSum = season switch
                {
                    "summer" => budget * 0.40,
                    "winter" => budget * 0.80,
                    _ => totalSum
                };
                break;
            }
            case > 1000:
                destination = "Europe";
                totalSum = budget * 0.90;
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"Hotel - {totalSum:f2}");
                break;
        }

        switch (season)
        {
            case "summer" when destination is "Bulgaria" or "Balkans":
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"Camp - {totalSum:f2}");
                break;
            case "winter" when destination is "Bulgaria" or "Balkans":
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"Hotel - {totalSum:f2}");
                break;
        }
    }
}