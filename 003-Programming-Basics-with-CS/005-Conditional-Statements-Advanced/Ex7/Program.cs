namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        if (number is >= 100 and <= 200 or 0)
        {
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}