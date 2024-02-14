namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        for (var i = 1; i <= number;)
        {
            Console.WriteLine(i);
            i = i * 2 + 1;
        }
    }
}