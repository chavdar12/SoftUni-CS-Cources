namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var cakeWidth = int.Parse(Console.ReadLine());
        var cakeLength = int.Parse(Console.ReadLine());
        var cakeSize = cakeWidth * cakeLength;
        var totalPieces = 0;
        while (true)
        {
            var cakePieces = Console.ReadLine();

            if (cakePieces == "STOP")
            {
                var piecesLeft = cakeSize - totalPieces;
                Console.WriteLine($"{piecesLeft} pieces are left.");
                break;
            }

            var cakePiece = int.Parse(cakePieces);
            totalPieces += cakePiece;
            if (totalPieces < cakeSize) continue;
            var piecesNeeded = cakeSize - totalPieces;
            Console.WriteLine($"No more cake left! You need {Math.Abs(piecesNeeded)} pieces more.");
            break;
        }
    }
}