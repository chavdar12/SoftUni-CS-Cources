namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var width = int.Parse(Console.ReadLine());
        var length = int.Parse(Console.ReadLine());
        var height = int.Parse(Console.ReadLine());

        var volume = width * length * height;
        var boxesVolume = 0;

        var input = Console.ReadLine();
        while (input != "Done")
        {
            var boxes = int.Parse(input);
            boxesVolume += boxes;
            if (boxesVolume > volume)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(boxesVolume - volume)} Cubic meters more.");
                break;
            }

            input = Console.ReadLine();
        }

        if (volume >= boxesVolume) Console.WriteLine($"{volume - boxesVolume} Cubic meters left.");
    }
}