namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());

        double sumEven = 0;
        var maxEven = -1000000000.0;
        var minEven = 1000000000.0;
        double sumOdd = 0;
        var maxOdd = -1000000000.0;
        var minOdd = 1000000000.0;


        for (var i = 0; i < count; i++)
        {
            var numbers = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                sumOdd += numbers;

                if (numbers > maxOdd) maxOdd = numbers;
                if (numbers < minOdd) minOdd = numbers;
            }
            else
            {
                sumEven += numbers;
                if (numbers > maxEven) maxEven = numbers;
                if (numbers < minEven) minEven = numbers;
            }
        }

        Console.WriteLine($"OddSum={sumOdd:f2},");
        if (count > 0)
        {
            Console.WriteLine($"OddMin={minOdd:f2},");
            Console.WriteLine($"OddMax={maxOdd:f2},");
        }
        else
        {
            Console.WriteLine($"OddMin=No,");
            Console.WriteLine($"OddMax=No,");
        }

        Console.WriteLine($"EvenSum={sumEven:f2},");
        if (count > 1)
        {
            Console.WriteLine($"EvenMin={minEven:f2},");
            Console.WriteLine($"EvenMax={maxEven:f2}");
        }
        else
        {
            Console.WriteLine($"EvenMin=No,");
            Console.WriteLine($"EvenMax=No");
        }
    }
}