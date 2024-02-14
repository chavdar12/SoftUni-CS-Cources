namespace Ex10;

internal class Program
{
    private static void Main(string[] args)
    {
        var studentsCount = int.Parse(Console.ReadLine());

        double lowPercent = 0;
        double averagePercent = 0;
        double goodPercent = 0;
        double excellentPercent = 0;

        double gradesSum = 0;

        for (var i = 0; i < studentsCount; i++)
        {
            var grade = double.Parse(Console.ReadLine());
            switch (grade)
            {
                case >= 2.00 and <= 2.99:
                    lowPercent++;
                    break;
                case >= 3.00 and <= 3.99:
                    averagePercent++;
                    break;
                case >= 4.00 and <= 4.99:
                    goodPercent++;
                    break;
                case >= 5.00:
                    excellentPercent++;
                    break;
            }

            gradesSum += grade;
        }

        Console.WriteLine($"Top students: {excellentPercent / studentsCount * 1.00 * 100:f2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {goodPercent / studentsCount * 1.00 * 100:f2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {averagePercent / studentsCount * 1.00 * 100:f2}%");
        Console.WriteLine($"Fail: {lowPercent / studentsCount * 1.00 * 100:f2}%");
        Console.WriteLine($"Average: {gradesSum / studentsCount * 1.00:f2}");
    }
}