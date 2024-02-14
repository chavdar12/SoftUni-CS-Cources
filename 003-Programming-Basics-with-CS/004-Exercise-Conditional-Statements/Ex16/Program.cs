namespace Ex16;

internal class Program
{
    private static void Main(string[] args)
    {
        var fuelType = Console.ReadLine();
        var litersInTank = double.Parse(Console.ReadLine());


        switch (litersInTank)
        {
            case >= 25 when fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas":
                Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                break;
            case >= 25:
                Console.WriteLine("Invalid fuel!");
                break;
            case < 25 when fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas":
                Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                break;
            case < 25:
                Console.WriteLine("Invalid fuel!");
                break;
        }
    }
}