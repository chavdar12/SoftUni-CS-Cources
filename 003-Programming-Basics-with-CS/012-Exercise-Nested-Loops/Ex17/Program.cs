namespace Ex17;

internal class Program
{
    private static void Main(string[] args)
    {
        var daysCount = int.Parse(Console.ReadLine());
        var hoursPerDay = int.Parse(Console.ReadLine());

        double totalPrice = 0;
        for (var i = 1; i <= daysCount; i++)
        {
            double price = 0;
            for (var j = 1; j <= hoursPerDay; j++)
                if (i % 2 == 0 && j % 2 != 0)
                    price += 2.50;
                else if (i % 2 != 0 && j % 2 == 0)
                    price += 1.25;
                else
                    price += 1;
            totalPrice += price;
            Console.WriteLine($"Day: {i} - {price:f2} leva");
        }

        Console.WriteLine($"Total: {totalPrice:f2} leva");
    }
}