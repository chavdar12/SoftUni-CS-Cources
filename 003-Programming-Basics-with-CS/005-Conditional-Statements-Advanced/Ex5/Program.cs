namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = double.Parse(Console.ReadLine());

        if (number is >= -100 and <= 100 && number != 0)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}