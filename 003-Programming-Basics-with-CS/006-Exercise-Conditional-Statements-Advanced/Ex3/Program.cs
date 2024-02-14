namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var deg = int.Parse(Console.ReadLine());
        var time = Console.ReadLine();

        var outfit = string.Empty;
        var shoes = string.Empty;


        switch (time)
        {
            case "Morning":
                switch (deg)
                {
                    case >= 10 and <= 18:
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case > 18 and <= 24:
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case >= 25:
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                }

                break;
            case "Afternoon":
                switch (deg)
                {
                    case >= 10 and <= 18:
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case > 18 and <= 24:
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case >= 25:
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                }

                break;
            case "Evening":
                switch (deg)
                {
                    case >= 10 and <= 18:
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case > 18 and <= 24:
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case >= 25:
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }

                break;
        }

        Console.WriteLine($"It's {deg} degrees, get your {outfit} and {shoes}.");
    }
}