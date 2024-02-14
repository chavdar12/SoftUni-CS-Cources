namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var sum = 0;
        while (number > sum)
        {
            var numbers = int.Parse(Console.ReadLine());
            sum += numbers;
        }

        Console.WriteLine(sum);
    }
}