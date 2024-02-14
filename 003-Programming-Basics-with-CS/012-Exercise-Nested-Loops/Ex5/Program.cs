namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var l = int.Parse(Console.ReadLine());

        for (var symbol1 = 1; symbol1 < n; symbol1++)
        for (var symbol2 = 1; symbol2 < n; symbol2++)
        for (int symbol3 = 'a'; symbol3 < 'a' + l; symbol3++)
        for (int symbol4 = 'a'; symbol4 < 'a' + l; symbol4++)
        for (var symbol5 = 1; symbol5 <= n; symbol5++)
            if (symbol5 > symbol1 && symbol5 > symbol2)
                Console.Write("" +
                              $"{symbol1}" +
                              $"{symbol2}" +
                              $"{(char)symbol3}" +
                              $"{(char)symbol4}" +
                              $"{symbol5} ");
    }
}