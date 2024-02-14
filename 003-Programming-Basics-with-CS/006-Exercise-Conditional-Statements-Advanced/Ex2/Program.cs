namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var projectionType = Console.ReadLine();
        var numberOfRows = int.Parse(Console.ReadLine());
        var numberOfColumns = int.Parse(Console.ReadLine());

        const double premiere = 12.00;
        const double normal = 7.50;
        const double discount = 5.00;

        var totalIncome = projectionType switch
        {
            "Premiere" => numberOfRows * numberOfColumns * premiere,
            "Normal" => numberOfRows * numberOfColumns * normal,
            "Discount" => numberOfRows * numberOfColumns * discount,
            _ => 0
        };

        Console.WriteLine($"{totalIncome:f2}");
    }
}