namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var triPrice = double.Parse(Console.ReadLine());
        var moneySheHave = double.Parse(Console.ReadLine());

        var daysSheSpend = 0;
        var totalDays = 0;

        while (true)
        {
            var action = Console.ReadLine();
            var money = double.Parse(Console.ReadLine());
            totalDays++;
            if (action == "spend")
            {
                daysSheSpend++;
                moneySheHave -= money;

                if (moneySheHave < 0) moneySheHave = 0;

                if (daysSheSpend == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{totalDays}");
                    break;
                }
            }
            else if (action == "save")
            {
                moneySheHave += money;
                daysSheSpend = 0;
            }

            if (!(moneySheHave >= triPrice)) continue;
            Console.WriteLine($"You saved the money for {totalDays} days.");
            break;
        }
    }
}