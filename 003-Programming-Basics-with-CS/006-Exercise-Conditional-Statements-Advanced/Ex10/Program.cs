namespace Ex10;

internal class Program
{
    private static void Main(string[] args)
    {
        var year = Console.ReadLine();
        var holidayNumbersAtTheYear = int.Parse(Console.ReadLine());
        var weekendsThatVladiTravels = int.Parse(Console.ReadLine());

        const int totalWeekends = 48;
        var totalWeekendsAtSofia = totalWeekends - weekendsThatVladiTravels;
        var saturdayGamesAtSofia = totalWeekendsAtSofia * 0.75;

        var gamesAtHolidays = holidayNumbersAtTheYear * 0.6667;
        var totalGames = saturdayGamesAtSofia + weekendsThatVladiTravels + gamesAtHolidays;

        if (year == "leap")
        {
            var percentForYear = 0.15 * totalGames;
            totalGames += percentForYear;
        }

        Console.WriteLine($"{Math.Floor(totalGames)}");
    }
}