namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var speed = double.Parse(Console.ReadLine());

        switch (speed)
        {
            case <= 10:
                Console.WriteLine("slow");
                break;
            case > 10 and <= 50:
                Console.WriteLine("average");
                break;
            case > 50 and <= 150:
                Console.WriteLine("fast");
                break;
            case > 150 and <= 1000:
                Console.WriteLine("ultra fast");
                break;
            case > 1000:
                Console.WriteLine("extremely fast");
                break;
        }
    }
}