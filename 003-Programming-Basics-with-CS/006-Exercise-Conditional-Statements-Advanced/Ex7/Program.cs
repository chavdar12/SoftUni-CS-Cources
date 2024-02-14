namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        var numbersOperator = char.Parse(Console.ReadLine());

        double result;

        if (secondNumber == 0)
            Console.WriteLine($"Cannot divide {firstNumber} by zero");

        else
            switch (numbersOperator)
            {
                case '+':
                case '-':
                case '*':
                {
                    switch (numbersOperator)
                    {
                        case '+':
                        {
                            result = firstNumber + secondNumber;
                            Console.WriteLine(result % 2 == 0
                                ? $"{firstNumber} {numbersOperator} {secondNumber} = {result} - even"
                                : $"{firstNumber} {numbersOperator} {secondNumber} = {result} - odd");
                            break;
                        }
                        case '-':
                        {
                            result = firstNumber - secondNumber;
                            Console.WriteLine(result % 2 == 0
                                ? $"{firstNumber} {numbersOperator} {secondNumber} = {result} - even"
                                : $"{firstNumber} {numbersOperator} {secondNumber} = {result} - odd");
                            break;
                        }
                        case '*':
                        {
                            result = firstNumber * secondNumber;
                            Console.WriteLine(result % 2 == 0
                                ? $"{firstNumber} {numbersOperator} {secondNumber} = {result} - even"
                                : $"{firstNumber} {numbersOperator} {secondNumber} = {result} - odd");
                            break;
                        }
                    }

                    break;
                }
                case '/':
                    result = firstNumber * 1.00 / secondNumber * 1.00;

                    Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result:f2}");
                    break;
                case '%':
                    result = firstNumber % secondNumber;
                    Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result}");
                    break;
            }
    }
}