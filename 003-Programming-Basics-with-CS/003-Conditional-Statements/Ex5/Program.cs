namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case < 100:
                Console.WriteLine("Less than 100");
                break;
            case >= 100 and <= 200:
                Console.WriteLine("Between 100 and 200");
                break;
            case > 200:
                Console.WriteLine("Greater than 200");
                break;
        }
    }
}