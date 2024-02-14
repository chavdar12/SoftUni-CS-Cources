namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var period = int.Parse(Console.ReadLine());

        var treated = 0;
        var untreated = 0;
        var doctors = 7;

        for (var i = 1; i <= period; i++)
        {
            var patients = int.Parse(Console.ReadLine());
            if (i % 3 == 0)
                if (untreated > treated)
                    doctors++;
            if (patients <= doctors)
            {
                treated += patients;
            }
            else if (patients > doctors)
            {
                untreated += patients - doctors;
                treated += doctors;
            }
        }

        Console.WriteLine($"Treated patients: {treated}.");
        Console.WriteLine($"Untreated patients: {untreated}.");
    }
}