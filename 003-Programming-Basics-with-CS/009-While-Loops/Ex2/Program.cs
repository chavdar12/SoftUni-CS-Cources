namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var user = Console.ReadLine();
        var pass = Console.ReadLine();

        var passwordInput = Console.ReadLine();
        while (passwordInput != pass) passwordInput = Console.ReadLine();
        Console.WriteLine($"Welcome {user}!");
    }
}