namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var month = Console.ReadLine();
        var nights = int.Parse(Console.ReadLine());

        double studio;
        double apartment;
        double sumStudio = 0;
        double sumApartment = 0;
        double discount;

        switch (month)
        {
            case "May":
            case "October":
            {
                studio = 50;
                sumStudio = studio * nights;
                apartment = 65;
                sumApartment = apartment * nights;
                switch (nights)
                {
                    case > 7 and < 14:
                        discount = sumStudio * 0.05;
                        sumStudio -= discount;
                        break;
                    case > 14:
                        discount = sumStudio * 0.30;
                        sumStudio -= discount;
                        break;
                }

                break;
            }
            case "June":
            case "September":
            {
                studio = 75.20;
                sumStudio = studio * nights;
                apartment = 68.70;
                sumApartment = apartment * nights;
                if (nights > 14)
                {
                    discount = sumStudio * 0.20;
                    sumStudio -= discount;
                }

                break;
            }
            case "July":
            case "August":
                studio = 76;
                sumStudio = studio * nights;
                apartment = 77;
                sumApartment = apartment * nights;
                break;
        }

        if (nights > 14)
        {
            discount = sumApartment * 0.10;
            sumApartment -= discount;
        }

        Console.WriteLine($"Apartment: {sumApartment:f2} lv.");
        Console.WriteLine($"Studio: {sumStudio:f2} lv.");
    }
}