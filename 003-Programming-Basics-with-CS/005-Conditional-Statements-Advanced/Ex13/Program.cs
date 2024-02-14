namespace Ex13;

internal class Program
{
    private static void Main(string[] args)
    {
        var day = Console.ReadLine();
        var price = 0;
        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Friday":
                price = 12;
                break;
            case "Wednesday":
            case "Thursday":
                price = 14;
                break;
            case "Saturday":
            case "Sunday":
                price = 16;
                break;
        }

        Console.WriteLine(price);
    }
}