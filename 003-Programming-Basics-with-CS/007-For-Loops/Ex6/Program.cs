namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine();
        double sum = 0;
        foreach (var letter in text)
            switch (letter)
            {
                case 'a':
                    sum += 1;
                    break;
                case 'e':
                    sum += 2;
                    break;
                case 'i':
                    sum += 3;
                    break;
                case 'o':
                    sum += 4;
                    break;
                case 'u':
                    sum += 5;
                    break;
            }

        Console.WriteLine(sum);
    }
}