namespace Ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        var timeOne = int.Parse(Console.ReadLine());
        var timeTwo = int.Parse(Console.ReadLine());
        var timeThree = int.Parse(Console.ReadLine());

        var totalTime = timeOne + timeThree + timeTwo;
        var minutes = totalTime / 60;
        var seconds = totalTime % 60;

        Console.WriteLine(seconds < 10 ? $"{minutes}:{seconds:d2}" : $"{minutes}:{seconds}");
    }
}