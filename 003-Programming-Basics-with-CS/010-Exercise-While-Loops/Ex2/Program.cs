namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var numberOfBadGrades = int.Parse(Console.ReadLine());

        var badGradesCounter = 0;
        var problemsNumber = 0;
        var lastProblem = " ";
        double sumGrades = 0;

        while (true)
        {
            var taskName = Console.ReadLine();
            if (taskName == "Enough")
            {
                Console.WriteLine($"Average score: {sumGrades / problemsNumber:f2}");
                Console.WriteLine($"Number of problems: {problemsNumber}");
                Console.WriteLine($"Last problem: {lastProblem}");
                break;
            }

            var grade = int.Parse(Console.ReadLine());
            if (grade <= 4.00) badGradesCounter++;
            if (badGradesCounter == numberOfBadGrades)
            {
                Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                break;
            }

            sumGrades += grade;
            problemsNumber++;
            lastProblem = taskName;
        }
    }
}