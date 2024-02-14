namespace Ex13;

internal class Program
{
    private static void Main(string[] args)
    {
        var stadiumCapacity = int.Parse(Console.ReadLine());
        var fansCount = int.Parse(Console.ReadLine());

        double sectorA = 0;
        double sectorB = 0;
        double sectorV = 0;
        double sectorG = 0;

        for (var i = 1; i <= fansCount; i++)
        {
            var sector = Console.ReadLine();
            switch (sector)
            {
                case "A":
                    sectorA++;
                    break;
                case "B":
                    sectorB++;
                    break;
                case "V":
                    sectorV++;
                    break;
                case "G":
                    sectorG++;
                    break;
            }
        }

        Console.WriteLine($"{sectorA / fansCount * 1.00 * 100:f2}%");
        Console.WriteLine($"{sectorB / fansCount * 1.00 * 100:f2}%");
        Console.WriteLine($"{sectorV / fansCount * 1.00 * 100:f2}%");
        Console.WriteLine($"{sectorG / fansCount * 1.00 * 100:f2}%");
        Console.WriteLine($"{fansCount * 1.00 / stadiumCapacity * 1.00 * 100:f2}%");
    }
}