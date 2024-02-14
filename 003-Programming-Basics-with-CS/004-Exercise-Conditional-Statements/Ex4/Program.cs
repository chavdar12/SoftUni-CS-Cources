namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var valueToConvert = double.Parse(Console.ReadLine());
        var metricIn = Console.ReadLine();
        var metricOut = Console.ReadLine();

        double converted = 0;

        converted = metricIn switch
        {
            "m" => metricOut switch
            {
                "cm" => valueToConvert * 100,
                "mm" => valueToConvert * 1000,
                _ => converted
            },
            "cm" => metricOut switch
            {
                "m" => valueToConvert * 0.01,
                "mm" => valueToConvert * 10,
                _ => converted
            },
            "mm" => metricOut switch
            {
                "cm" => valueToConvert * 0.1,
                "m" => valueToConvert * 0.001,
                _ => converted
            },
            _ => converted
        };

        Console.WriteLine($"{converted:f3}");
    }
}