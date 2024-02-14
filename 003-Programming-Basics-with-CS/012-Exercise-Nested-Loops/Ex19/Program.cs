namespace Ex19;

internal class Program
{
    private static void Main(string[] args)
    {
        var startingValueOfFirstTwo = int.Parse(Console.ReadLine());
        var startingValueOfSecondTwo = int.Parse(Console.ReadLine());
        var differenceBetweenStartAndEndFirst = int.Parse(Console.ReadLine());
        var differenceBetweenStartAndEndSecond = int.Parse(Console.ReadLine());

        for (var i = startingValueOfFirstTwo; i <= startingValueOfFirstTwo + differenceBetweenStartAndEndFirst; i++)
        for (var j = startingValueOfSecondTwo; j <= startingValueOfSecondTwo + differenceBetweenStartAndEndSecond; j++)
        {
            var isIPrime = true;
            var isJPrime = true;

            for (var k = 2; k <= Math.Sqrt(i); k++)
                if (i % k == 0)
                {
                    isIPrime = false;
                    break;
                }

            for (var k = 2; k <= Math.Sqrt(j); k++)
                if (j % k == 0)
                {
                    isJPrime = false;
                    break;
                }

            if (isIPrime && isJPrime) Console.WriteLine($"{i}{j}");
        }
    }
}