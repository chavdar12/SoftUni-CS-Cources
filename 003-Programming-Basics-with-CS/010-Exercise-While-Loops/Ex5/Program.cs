namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        var coins = double.Parse(Console.ReadLine());
        var levs = Math.Floor(coins);
        var monets = Math.Round((coins - levs) * 100);
        double counter = 0;

        while (levs > 0)
            switch (levs)
            {
                case >= 2:
                    counter++;
                    levs -= 2;
                    break;
                case >= 1 when !(monets > 0):
                    continue;
                case >= 1:
                    counter++;
                    levs -= 1;
                    break;
            }

        while (monets > 0)
            if (monets >= 50)
            {
                counter++;
                monets -= 50;
            }
            else if (monets >= 50)
            {
                counter++;
                monets -= 50;
            }
            else if (monets >= 20)
            {
                counter++;
                monets -= 20;
            }
            else if (monets >= 10)
            {
                counter++;
                monets -= 10;
            }
            else if (monets >= 05)
            {
                counter++;
                monets -= 05;
            }
            else if (monets >= 02)
            {
                counter++;
                monets -= 02;
            }
            else if (monets >= 01)
            {
                counter++;
                monets -= 01;
                break;
            }
            else
            {
                break;
            }

        Console.WriteLine(counter);
    }
}