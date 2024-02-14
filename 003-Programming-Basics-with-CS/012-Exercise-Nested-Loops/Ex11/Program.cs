namespace Ex11;

internal class Program
{
    private static void Main(string[] args)
    {
        var mens = int.Parse(Console.ReadLine());
        var women = int.Parse(Console.ReadLine());
        var maxTables = int.Parse(Console.ReadLine());

        var tablesCounter = 0;

        for (var i = 1; i <= mens; i++)
        for (var j = 1; j <= women; j++)
        {
            Console.Write($"({i} <-> {j}) ");
            tablesCounter++;

            if (tablesCounter == maxTables) return;
        }
    }
}