namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        var destination = Console.ReadLine();

        while (destination != "End")
        {
            var budget = double.Parse(Console.ReadLine());
            double savedMoney = 0;
            while (savedMoney < budget) savedMoney += double.Parse(Console.ReadLine());
            Console.WriteLine($"Going to {destination}!");
            destination = Console.ReadLine();
        }
    }
}