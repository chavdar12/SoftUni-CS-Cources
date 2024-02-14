namespace Ex9;

internal class Program
{
    private static void Main(string[] args)
    {
        var town = Console.ReadLine();
        var sales = double.Parse(Console.ReadLine());

        double commission = 0;

        switch (town)
        {
            case "Sofia":
                switch (sales)
                {
                    case >= 0 and <= 500:
                        commission = 0.05;
                        break;
                    case > 500 and <= 1000:
                        commission = 0.07;
                        break;
                    case > 1000 and <= 10000:
                        commission = 0.08;
                        break;
                    case > 10000:
                        commission = 0.12;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                break;
            case "Varna":
                switch (sales)
                {
                    case >= 0 and <= 500:
                        commission = 0.045;
                        break;
                    case > 500 and <= 1000:
                        commission = 0.075;
                        break;
                    case > 1000 and <= 10000:
                        commission = 0.10;
                        break;
                    case > 10000:
                        commission = 0.13;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                break;
            case "Plovdiv":
                switch (sales)
                {
                    case >= 0 and <= 500:
                        commission = 0.055;
                        break;
                    case > 500 and <= 1000:
                        commission = 0.08;
                        break;
                    case > 1000 and <= 10000:
                        commission = 0.12;
                        break;
                    case > 10000:
                        commission = 0.145;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                break;
            default:
                Console.WriteLine("error");
                break;
        }

        var totalSum = sales * commission;
        if (commission > 0) Console.WriteLine($"{totalSum:f2}");
    }
}