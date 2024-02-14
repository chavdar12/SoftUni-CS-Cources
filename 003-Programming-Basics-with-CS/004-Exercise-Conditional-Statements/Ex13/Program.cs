namespace Ex13;

internal class Program
{
    private static void Main(string[] args)
    {
        var projectHours = int.Parse(Console.ReadLine());
        var projectDays = int.Parse(Console.ReadLine());
        var workersThatTakingOvertime = int.Parse(Console.ReadLine());

        var timeAfterTraining = projectDays - projectDays * 0.10;
        var time = timeAfterTraining * 8;
        var overtime = workersThatTakingOvertime * 2 * projectDays;
        var totalHours = Math.Floor(time + overtime);

        if (projectHours <= totalHours)
        {
            var hoursLeft = Math.Abs(projectHours - totalHours);
            Console.WriteLine($"Yes!{Math.Floor(hoursLeft)} hours left.");
        }
        else if (projectHours > totalHours)
        {
            var timeNeeded = Math.Abs(totalHours - projectHours);
            Console.WriteLine($"Not enought time!{Math.Floor(timeNeeded)} hours needed.");
        }
    }
}