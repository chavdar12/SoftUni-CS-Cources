namespace Ex10;

internal class Program
{
    private static void Main(string[] args)
    {
        var daysInTheHotel = int.Parse(Console.ReadLine());
        var roomType = Console.ReadLine();
        var feedback = Console.ReadLine();

        const double roomForOnePerson = 18.00;
        const double apartment = 25.00;
        const double presidentApartment = 35.00;

        var totalEvenings = daysInTheHotel - 1;
        double discount = 0;
        double totalSum = 0;
        switch (roomType)
        {
            case "room for one person":
                totalSum = totalEvenings * roomForOnePerson;
                break;
            case "apartment":
            {
                totalSum = totalEvenings * apartment;
                discount = daysInTheHotel switch
                {
                    < 10 => totalSum * 0.30,
                    >= 10 and <= 15 => totalSum * 0.35,
                    > 15 => totalSum * 0.50
                };

                break;
            }
            case "president apartment":
            {
                totalSum = totalEvenings * presidentApartment;
                discount = daysInTheHotel switch
                {
                    < 10 => totalSum * 0.10,
                    >= 10 and <= 15 => totalSum * 0.15,
                    > 15 => totalSum * 0.20
                };
                break;
            }
        }

        totalSum -= discount;


        switch (feedback)
        {
            case "positive":
                totalSum += totalSum * 0.25;
                break;
            case "negative":
                totalSum -= totalSum * 0.10;
                break;
        }

        Console.WriteLine($"{totalSum:f2}");
    }
}