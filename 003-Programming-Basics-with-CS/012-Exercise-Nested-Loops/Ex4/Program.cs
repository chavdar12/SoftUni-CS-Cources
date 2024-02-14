namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var countOfTheJury = int.Parse(Console.ReadLine());
        double totalGradesSum = 0;
        var presentationsCount = 0;

        var presentationName = Console.ReadLine();
        while (presentationName != "Finish")
        {
            double gradesSum = 0;
            for (var i = 0; i < countOfTheJury; i++)
            {
                var presentationGrade = double.Parse(Console.ReadLine());
                gradesSum += presentationGrade;
                presentationsCount++;
            }

            totalGradesSum += gradesSum;
            var averageGrade = gradesSum / countOfTheJury;
            Console.WriteLine($"{presentationName} - {averageGrade:f2}.");

            presentationName = Console.ReadLine();
        }

        var finalGrade = totalGradesSum / presentationsCount;
        Console.WriteLine($"Student's final assessment is {finalGrade:f2}.");
    }
}