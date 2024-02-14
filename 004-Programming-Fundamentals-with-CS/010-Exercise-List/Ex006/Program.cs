namespace Ex006;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstPlayer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();
        var secondPlayer = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        while (firstPlayer.Count != 0 || secondPlayer.Count != 0)
        {
            if (firstPlayer[0] == secondPlayer[0])
            {
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }
            else if (firstPlayer[0] > secondPlayer[0])
            {
                firstPlayer.Add(secondPlayer[0]);
                firstPlayer.Add(firstPlayer[0]);
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }
            else if (firstPlayer[0] < secondPlayer[0])
            {
                secondPlayer.Add(firstPlayer[0]);
                secondPlayer.Add(secondPlayer[0]);
                secondPlayer.RemoveAt(0);
                firstPlayer.RemoveAt(0);
            }

            int sum;
            if (firstPlayer.Count == 0)
            {
                sum = secondPlayer.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
                break;
            }

            if (secondPlayer.Count != 0) continue;
            sum = firstPlayer.Sum();
            Console.WriteLine($"First player wins! Sum: {sum}");
            break;
        }
    }
}