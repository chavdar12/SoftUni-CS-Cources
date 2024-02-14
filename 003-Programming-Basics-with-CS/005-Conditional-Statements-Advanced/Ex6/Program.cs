namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var product = Console.ReadLine();

        switch (product)
        {
            case "banana":
            case "apple":
            case "cherry":
            case "lemon":
            case "grapes":
            case "kiwi":
                Console.WriteLine("fruit");
                break;
            case "tomato":
            case "cucumber":
            case "pepper":
            case "carrot":
                Console.WriteLine("vegetable");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}