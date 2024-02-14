namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var openedTabs = int.Parse(Console.ReadLine());
        var salary = int.Parse(Console.ReadLine());

        for (var i = 1; i <= openedTabs; i++)
        {
            var websiteName = Console.ReadLine();
            switch (websiteName)
            {
                case "Facebook":
                    salary -= 150;
                    break;
                case "Instagram":
                    salary -= 100;
                    break;
                case "Reddit":
                    salary -= 50;
                    break;
            }

            if (salary != 0) continue;
            Console.WriteLine("You have lost your salary.");
            break;
        }

        if (salary > 0) Console.WriteLine($"{salary}");
    }
}