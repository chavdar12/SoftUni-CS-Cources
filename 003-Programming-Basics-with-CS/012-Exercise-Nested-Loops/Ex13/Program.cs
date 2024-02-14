namespace Ex13;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        var maxPasswordsCount = int.Parse(Console.ReadLine());

        var firstSymbol = 35;
        var secondSymbol = 64;
        var passwordsCombo = string.Empty;
        var passwordsCounter = 0;

        for (var thirdSymbol = 1; thirdSymbol <= firstNumber; thirdSymbol++)
        for (var forthSymbol = 1; forthSymbol <= secondNumber; forthSymbol++)
        {
            var charFirstSymbol = (char)firstSymbol;
            var charSecondSymbol = (char)secondSymbol;

            passwordsCombo += $"" +
                              $"{charFirstSymbol}" +
                              $"{charSecondSymbol}" +
                              $"{thirdSymbol}" +
                              $"{forthSymbol}" +
                              $"{charSecondSymbol}" +
                              $"{charFirstSymbol}|";

            passwordsCounter++;

            if (passwordsCounter >= maxPasswordsCount)
            {
                Console.WriteLine(passwordsCombo);
                return;
            }

            firstSymbol++;
            secondSymbol++;

            if (firstSymbol > 55) firstSymbol = 35;
            if (secondSymbol > 96) secondSymbol = 64;
        }

        Console.WriteLine(passwordsCombo);
    }
}