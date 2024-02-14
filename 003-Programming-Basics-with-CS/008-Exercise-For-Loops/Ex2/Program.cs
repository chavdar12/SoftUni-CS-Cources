namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = int.Parse(Console.ReadLine());

        var totalSum = 0;
        var max = int.MinValue;

        for (var i = 0; i < numbers; i++)
        {
            var nums = int.Parse(Console.ReadLine());
            totalSum += nums;
            if (nums > max) max = nums;
        }

        var sumWithoutMax = totalSum - max;
        if (sumWithoutMax == max)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {max}");
        }
        else
        {
            var diff = Math.Abs(max - sumWithoutMax);
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {diff}");
        }
    }
}