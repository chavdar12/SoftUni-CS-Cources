namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var totalSteps = 0;

        while (true)
        {
            var stepsCounter = Console.ReadLine();
            if (stepsCounter == "Going home")
            {
                var homeSteps = int.Parse(Console.ReadLine());
                totalSteps += homeSteps;
                if (totalSteps < 10000)
                {
                    Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
                }

                break;
            }

            var steps = int.Parse(stepsCounter);
            totalSteps += steps;
            if (totalSteps < 10000) continue;
            Console.WriteLine($"Goal reached! Good job!");
            Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            break;
        }
    }
}