namespace Ex10;

internal class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());

        var evenSum = 0;
        var oddSum = 0;

        for (var i = 1; i <= count; i++)
        {
            var numbers = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
                evenSum += numbers;
            else
                oddSum += numbers;
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {evenSum}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}