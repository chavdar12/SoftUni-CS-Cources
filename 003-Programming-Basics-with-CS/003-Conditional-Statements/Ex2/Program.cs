namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(num1 > num2 ? num1 : num2);
    }
}