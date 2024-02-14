namespace Ex9;

internal class Program
{
    private static void Main(string[] args)
    {
        var examHour = int.Parse(Console.ReadLine());
        var examMinute = int.Parse(Console.ReadLine());
        var arriveHour = int.Parse(Console.ReadLine());
        var arriveMinute = int.Parse(Console.ReadLine());

        var examTotalMinutes = examHour * 60 + examMinute;
        var arriveTotalMinutes = arriveHour * 60 + arriveMinute;

        if (examTotalMinutes == arriveTotalMinutes)
        {
            Console.WriteLine("On time");
        }
        else if (examTotalMinutes > arriveTotalMinutes)
        {
            switch (examTotalMinutes - arriveTotalMinutes)
            {
                case > 30:
                {
                    var minutesLeft = examTotalMinutes - arriveTotalMinutes;
                    switch (minutesLeft)
                    {
                        case >= 1 and < 60:
                            Console.WriteLine("Early");
                            Console.WriteLine($"{minutesLeft} minutes before the start");
                            break;
                        case >= 60:
                        {
                            var hours = minutesLeft / 60;
                            var minutes = minutesLeft % 60;
                            if (minutes < 10)
                            {
                                Console.WriteLine("Early");
                                Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                            }
                            else
                            {
                                Console.WriteLine("Early");
                                Console.WriteLine($"{hours}:{minutes} hours before the start");
                            }

                            break;
                        }
                    }

                    break;
                }
                case <= 30:
                {
                    var minutesLeft = examTotalMinutes - arriveTotalMinutes;
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutesLeft} minutes before the start");
                    break;
                }
            }
        }
        else if (arriveTotalMinutes > examTotalMinutes)
        {
            var minutesNeeded = arriveTotalMinutes - examTotalMinutes;
            switch (minutesNeeded)
            {
                case >= 1 and < 60:
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutesNeeded} minutes after the start");
                    break;
                case >= 60:
                {
                    var hours = minutesNeeded / 60;
                    var minutes = minutesNeeded % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }

                    break;
                }
            }
        }
    }
}