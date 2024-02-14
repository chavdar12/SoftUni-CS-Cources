namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var animalType = Console.ReadLine();

        switch (animalType)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}