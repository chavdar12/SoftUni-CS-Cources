namespace Ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        var grade = double.Parse(Console.ReadLine());

        if (grade >= 5.50) Console.WriteLine("Excellent!");
    }
}