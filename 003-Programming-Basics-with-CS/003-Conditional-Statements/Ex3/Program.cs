namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        Console.WriteLine(num % 2 == 0 ? "even" : "odd");
    }
}