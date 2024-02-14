namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var recordInSeconds = double.Parse(Console.ReadLine());
        var distanceInMeters = double.Parse(Console.ReadLine());
        var oneMeterSwimPerSeconds = double.Parse(Console.ReadLine());

        var swimmingTime = distanceInMeters * oneMeterSwimPerSeconds;
        var slowingSeconds = Math.Floor(distanceInMeters / 15) * 12.5;

        var totalTime = swimmingTime + slowingSeconds;

        if (totalTime < recordInSeconds)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
        }
        else
        {
            var timeNeeded = totalTime - recordInSeconds;
            Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
        }
    }
}