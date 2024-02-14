namespace Ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        var dayOfTheWeek = int.Parse(Console.ReadLine());
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.WriteLine(dayOfTheWeek is >= 1 and <= 7 ? days[dayOfTheWeek - 1] : "Error");
    }
}