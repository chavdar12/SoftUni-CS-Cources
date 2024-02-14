namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var primesSum = 0;
        var nonPrimesSum = 0;

        var input = Console.ReadLine();
        while (input != "stop")
        {
            var numbers = int.Parse(input);
            var isNumberPrime = true;

            if (numbers < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else
            {
                for (var i = 2; i <= numbers; i++)
                    if (numbers % i == 0 && i != numbers)
                    {
                        isNumberPrime = false;
                        break;
                    }

                switch (isNumberPrime)
                {
                    case true:
                        primesSum += numbers;
                        break;
                    case false:
                        nonPrimesSum += numbers;
                        break;
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Sum of all prime numbers is: {primesSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonPrimesSum}");
    }
}