namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var studentName = Console.ReadLine();
        var gradeCounter = 0;
        var excludeCounter = 0;
        double gradesSum = 0;
        while (gradeCounter < 12)
        {
            var grades = double.Parse(Console.ReadLine());
            switch (grades)
            {
                case >= 4.00:
                    gradesSum += grades;
                    break;
                case < 4.00:
                    excludeCounter++;
                    break;
            }

            if (excludeCounter > 1) break;
            gradeCounter++;
        }

        if (gradeCounter == 12)
        {
            var averageGrade = gradesSum / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
        }
        else
        {
            Console.WriteLine($"{studentName} has been excluded at {gradeCounter} grade");
        }
    }
}