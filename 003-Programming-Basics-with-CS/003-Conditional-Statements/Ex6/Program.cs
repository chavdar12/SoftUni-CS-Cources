namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var passwordInsert = Console.ReadLine();
        const string password = "s3cr3t!P@ssw0rd";

        Console.WriteLine(passwordInsert == password ? "Welcome" : "Wrong password!");
    }
}