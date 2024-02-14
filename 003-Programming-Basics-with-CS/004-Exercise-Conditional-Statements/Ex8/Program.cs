namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var income = double.Parse(Console.ReadLine());
        var averageSuccess = double.Parse(Console.ReadLine());
        var minimalSalary = double.Parse(Console.ReadLine());

        if (income <= minimalSalary && averageSuccess > 4.50 && averageSuccess < 5.50)
        {
            var scholarship = Math.Floor(minimalSalary * 0.35);
            Console.WriteLine($"You get a Social scholarship {scholarship} BGN");
        }
        else if (averageSuccess >= 5.50)
        {
            var scholarshipExcellent = Math.Floor(averageSuccess * 25);
            Console.WriteLine($"You get a scholarship for excellent results {scholarshipExcellent} BGN");
        }
        else
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
    }
}