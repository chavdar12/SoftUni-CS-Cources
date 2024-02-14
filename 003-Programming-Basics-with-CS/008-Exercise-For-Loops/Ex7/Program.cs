namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var money = double.Parse(Console.ReadLine());
        var year = int.Parse(Console.ReadLine());
        var ageCounter = 18;
        for (var i = 1800; i <= year; i++)
        {
            if (i % 2 == 0)
                money -= 12000;
            else
                money -= 12000 + ageCounter * 50;
            ageCounter++;
        }

        Console.WriteLine(money >= 0
            ? $"Yes! He will live a carefree life and will have {money:f2} dollars left."
            : $"He will need {Math.Abs(money):f2} dollars to survive.");
    }
}