using System.Globalization;

namespace Ex013;

internal class Program
{
    private static void Main(string[] args)
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
            if (date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                holidaysCount++;

        Console.WriteLine(holidaysCount);
    }
}