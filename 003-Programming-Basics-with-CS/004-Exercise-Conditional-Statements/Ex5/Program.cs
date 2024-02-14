namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        var inputHours = int.Parse(Console.ReadLine());
        var inputMinutes = int.Parse(Console.ReadLine());

        var convertToMinutes = inputHours * 60 + inputMinutes + 15;
        var convertedToHours = convertToMinutes / 60;

        if (convertedToHours >= 24) convertedToHours = 0;
        var totalMinutes = convertToMinutes % 60;

        Console.WriteLine($"{convertedToHours}:{totalMinutes:d2}");
    }
}