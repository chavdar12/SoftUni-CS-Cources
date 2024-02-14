namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var pointsNumber = int.Parse(Console.ReadLine());
        double bonusPoints = 0;

        switch (pointsNumber)
        {
            case <= 100:
                bonusPoints += 5;
                break;
            case > 100 and < 1000:
                bonusPoints = pointsNumber * 0.20;
                break;
            case > 1000:
                bonusPoints = pointsNumber * 0.10;
                break;
        }

        if (pointsNumber % 2 == 0) bonusPoints += 1;
        if (pointsNumber % 10 == 5) bonusPoints += 2;

        Console.WriteLine(bonusPoints);
        Console.WriteLine(pointsNumber + bonusPoints);
    }
}