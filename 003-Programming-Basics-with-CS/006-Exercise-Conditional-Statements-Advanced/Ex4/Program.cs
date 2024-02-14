namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var flowerType = Console.ReadLine();
        var flowersCount = int.Parse(Console.ReadLine());
        var budget = int.Parse(Console.ReadLine());

        double totalSum = 0;
        double discount;

        switch (flowerType)
        {
            case "Roses":
                totalSum = flowersCount * 5.00;
                if (flowersCount > 80)
                {
                    discount = totalSum * 0.10;
                    totalSum -= discount;
                }

                break;
            case "Dahlias":
                totalSum = flowersCount * 3.80;
                if (flowersCount > 90)
                {
                    discount = totalSum * 0.15;
                    totalSum -= discount;
                }

                break;
            case "Tulips":
                totalSum = flowersCount * 2.80;
                if (flowersCount > 80)
                {
                    discount = totalSum * 0.15;
                    totalSum -= discount;
                }

                break;
            case "Narcissus":
                totalSum = flowersCount * 3.00;
                if (flowersCount < 120)
                {
                    discount = totalSum * 0.15;
                    totalSum += discount;
                }

                break;
            case "Gladiolus":
                totalSum = flowersCount * 2.50;
                if (flowersCount < 80)
                {
                    discount = totalSum * 0.20;
                    totalSum += discount;
                }

                break;
        }

        if (budget >= totalSum)
        {
            var moneyLeft = budget - totalSum;
            Console.WriteLine(
                $"Hey, you have a great garden with {flowersCount} {flowerType} and {moneyLeft:f2} leva left.");
        }
        else if (totalSum > budget)
        {
            var moneyNeeded = totalSum - budget;
            Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
        }
    }
}