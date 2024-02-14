namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());

        for (var i = firstNumber; i <= secondNumber; i++)
        {
            var evenSum = 0;
            var oddSum = 0;
            var currNum = i.ToString();
            for (var j = 0; j < currNum.Length; j++)
            {
                var currentNumber = int.Parse(currNum[j].ToString());
                if (j % 2 == 0)
                    evenSum += currentNumber;
                else
                    oddSum += currentNumber;
            }

            if (evenSum == oddSum) Console.Write($"{i} ");
        }
    }
}