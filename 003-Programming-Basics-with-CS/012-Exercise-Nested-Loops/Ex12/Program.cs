namespace Ex12;

internal class Program
{
    private static void Main(string[] args)
    {
        var lastSector = char.Parse(Console.ReadLine());
        var rowsNumber = int.Parse(Console.ReadLine());
        var placesAtOddRows = int.Parse(Console.ReadLine());

        var totalPlacesCounter = 0;
        for (int i = 'A'; i <= lastSector; i++)
        {
            for (var j = 1; j <= rowsNumber; j++)
                if (j % 2 != 0)
                    for (var k = 1; k <= placesAtOddRows; k++)
                    {
                        Console.WriteLine($"{(char)i}{j}{(char)(k + 96)}");
                        totalPlacesCounter++;
                    }
                else if (j % 2 == 0)
                    for (var k = 1; k <= placesAtOddRows + 2; k++)
                    {
                        Console.WriteLine($"{(char)i}{j}{(char)(k + 96)}");
                        totalPlacesCounter++;
                    }

            rowsNumber++;
        }

        Console.WriteLine($"{totalPlacesCounter}");
    }
}