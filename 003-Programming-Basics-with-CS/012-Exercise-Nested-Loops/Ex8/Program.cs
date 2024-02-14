namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var letter1 = char.Parse(Console.ReadLine());
        var letter2 = char.Parse(Console.ReadLine());
        var missedLetter = char.Parse(Console.ReadLine());

        var combinationsCounter = 0;
        for (var i = letter1; i <= letter2; i++)
        for (var j = letter1; j <= letter2; j++)
        for (var k = letter1; k <= letter2; k++)
            if (i == missedLetter || j == missedLetter || k == missedLetter)
            {
            }
            else
            {
                Console.Write($"{i}{j}{k} ");
                combinationsCounter++;
            }

        Console.Write(combinationsCounter);
    }
}