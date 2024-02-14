namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = int.Parse(Console.ReadLine());
        double sum = 0;
        for (var i = 0; i < numbers; i++)
        {
            var numbersToCount = int.Parse(Console.ReadLine());
            sum += numbersToCount;
        }

        Console.WriteLine(sum);
    }
}