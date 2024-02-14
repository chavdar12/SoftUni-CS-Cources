namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var age = double.Parse(Console.ReadLine());
        var gender = Console.ReadLine();

        switch (gender)
        {
            case "m":
                switch (age)
                {
                    case >= 16:
                        Console.WriteLine("Mr.");
                        break;
                    case < 16:
                        Console.WriteLine("Master");
                        break;
                }

                break;
            case "f":
                switch (age)
                {
                    case >= 16:
                        Console.WriteLine("Ms.");
                        break;
                    case < 16:
                        Console.WriteLine("Miss");
                        break;
                }

                break;
        }
    }
}