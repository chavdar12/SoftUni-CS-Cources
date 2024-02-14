namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var floors = int.Parse(Console.ReadLine());
        var rooms = int.Parse(Console.ReadLine());

        for (var floor = floors; floor >= 1; floor--)
        {
            for (var room = 0; room < rooms; room++)
                if (floor == floors)
                    Console.Write($"L{floor}{room} ");
                else if (floor % 2 == 0)
                    Console.Write($"O{floor}{room} ");
                else
                    Console.Write($"A{floor}{room} ");
            Console.WriteLine();
        }
    }
}