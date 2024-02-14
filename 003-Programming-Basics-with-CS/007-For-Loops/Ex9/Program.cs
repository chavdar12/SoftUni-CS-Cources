namespace Ex9;

internal class Program
{
    private static void Main(string[] args)
    {
        var countOfNumbers = int.Parse(Console.ReadLine());

        var leftSum = 0;
        var rightSum = 0;
        for (var i = 0; i < 2 * countOfNumbers; i++)
        {
            var number = int.Parse(Console.ReadLine());
            if (i < countOfNumbers)
                leftSum += number;
            else
                rightSum += number;
        }

        Console.WriteLine(leftSum == rightSum ? $"Yes, sum = {leftSum}" : $"No, diff = {Math.Abs(leftSum - rightSum)}");
    }
}