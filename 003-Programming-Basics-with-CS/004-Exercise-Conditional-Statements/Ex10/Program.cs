namespace Ex10;

internal class Program
{
    private static void Main(string[] args)
    {
        var restDays = int.Parse(Console.ReadLine());

        var playingInRestDays = restDays * 127;
        var playingInWorkingDays = 365 - restDays;
        playingInWorkingDays *= 63;
        var totalMinutesPlayed = playingInRestDays + playingInWorkingDays;

        int hours;
        int minutes;

        switch (totalMinutesPlayed)
        {
            case > 30000:
            {
                var timePlus = totalMinutesPlayed - 30000;
                hours = Math.Abs(timePlus / 60);
                minutes = Math.Abs(timePlus % 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
                break;
            }
            case <= 30000:
            {
                var timeLeft = totalMinutesPlayed - 30000;
                hours = Math.Abs(timeLeft / 60);
                minutes = Math.Abs(timeLeft % 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} less for play");
                break;
            }
        }
    }
}