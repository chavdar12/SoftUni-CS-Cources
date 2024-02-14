namespace Ex15;

internal class Program
{
    private static void Main(string[] args)
    {
        for (var hours = 0; hours <= 23; hours++)
        for (var minutes = 0; minutes <= 59; minutes++)
        for (var seconds = 0; seconds <= 59; seconds++)
        for (var milliseconds = 0; milliseconds <= 1000; milliseconds++)
            Console.WriteLine($"{hours} : {minutes} : {seconds} : {milliseconds}");
    }
}