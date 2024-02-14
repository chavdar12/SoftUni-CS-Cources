namespace Ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        var favoriteBook = Console.ReadLine();
        var check = 0;

        var input = Console.ReadLine();
        while (input != "No More Books")
        {
            if (input == favoriteBook)
            {
                Console.WriteLine($"You checked {check} books and found it.");
                break;
            }

            check++;
            input = Console.ReadLine();
        }

        if (input != "No More Books") return;
        Console.WriteLine($"The book you search is not here!");
        Console.WriteLine($"You checked {check} books.");
    }
}