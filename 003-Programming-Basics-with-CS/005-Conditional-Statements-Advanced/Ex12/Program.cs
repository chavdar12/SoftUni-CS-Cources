namespace Ex12;

internal class Program
{
    private static void Main(string[] args)
    {
        var hour = int.Parse(Console.ReadLine());
        var day = Console.ReadLine();
        if (hour is >= 10 and <= 18 &&
            day is "Monday" or "Tuesday" or "Wednesday" or "Thursday" or "Friday" or "Saturday")
            Console.WriteLine("open");
        else
            Console.WriteLine("closed");
    }
}