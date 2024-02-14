namespace Ex12;

internal class Program
{
    private static void Main(string[] args)
    {
        var km = int.Parse(Console.ReadLine());
        var dayOrNight = Console.ReadLine();

        const double taxiStartingPrice = 0.70;
        double busPrice = 0;
        double trainPrice = 0;

        switch (km)
        {
            case < 20:
            {
                double taxiPrice;
                switch (dayOrNight)
                {
                    case "day":
                        taxiPrice = taxiStartingPrice + km * 0.79;
                        Console.WriteLine($"{taxiPrice:f2}");
                        break;
                    case "night":
                        taxiPrice = taxiStartingPrice + km * 0.90;
                        Console.WriteLine($"{taxiPrice:f2}");
                        break;
                }

                break;
            }
            case >= 100:
            {
                if (dayOrNight is "day" or "night") trainPrice = 0.06 * km;
                break;
            }
            case >= 20:
            {
                if (dayOrNight is "day" or "night") busPrice = 0.09 * km;
                break;
            }
        }


        if (busPrice > trainPrice)
            Console.WriteLine($"{busPrice:f2}");
        else if (trainPrice > busPrice) Console.WriteLine($"{trainPrice:f2}");
    }
}