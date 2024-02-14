namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var studentsCounter = 0;
        var standardCounter = 0;
        var kidCounter = 0;
        var totalTickets = 0;

        while (true)
        {
            var movieName = Console.ReadLine();
            if (movieName == "Finish") break;
            var freePlace = int.Parse(Console.ReadLine());
            var currentTickets = 0;
            for (var i = 0; i < freePlace; i++)
            {
                var ticketType = Console.ReadLine();
                if (ticketType == "End")
                    break;
                switch (ticketType)
                {
                    case "student":
                        studentsCounter++;
                        break;
                    case "standard":
                        standardCounter++;
                        break;
                    case "kid":
                        kidCounter++;
                        break;
                }

                totalTickets++;
                currentTickets++;
            }

            Console.WriteLine($"{movieName} - {currentTickets * 1.00 / freePlace * 1.00 * 100:f2}% full.");
        }

        Console.WriteLine($"Total tickets: {totalTickets}");
        Console.WriteLine($"{studentsCounter * 1.00 / totalTickets * 100:f2}% student tickets.");
        Console.WriteLine($"{standardCounter * 1.00 / totalTickets * 100:f2}% standard tickets.");
        Console.WriteLine($"{kidCounter * 1.00 / totalTickets * 100:f2}% kids tickets.");
    }
}