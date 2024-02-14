namespace Ex008;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        bool Condition(string str)
        {
            return str.Length <= n;
        }

        Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().FindAll(Condition)
            .ForEach(Console.WriteLine);
    }
}