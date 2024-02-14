namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var product = Console.ReadLine();
        var town = Console.ReadLine();
        var qty = double.Parse(Console.ReadLine());

        double totalSum = 0;

        totalSum = town switch
        {
            "Sofia" => product switch
            {
                "coffee" => qty * 0.50,
                "water" => qty * 0.80,
                "beer" => qty * 1.20,
                "sweets" => qty * 1.45,
                "peanuts" => qty * 1.60,
                _ => totalSum
            },
            "Plovdiv" => product switch
            {
                "coffee" => qty * 0.40,
                "water" => qty * 0.70,
                "beer" => qty * 1.15,
                "sweets" => qty * 1.30,
                "peanuts" => qty * 1.50,
                _ => totalSum
            },
            "Varna" => product switch
            {
                "coffee" => qty * 0.45,
                "water" => qty * 0.70,
                "beer" => qty * 1.10,
                "sweets" => qty * 1.35,
                "peanuts" => qty * 1.55,
                _ => totalSum
            },
            _ => totalSum
        };

        Console.WriteLine(totalSum);
    }
}