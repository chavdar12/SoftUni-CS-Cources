namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var figure = Console.ReadLine();

        switch (figure)
        {
            case "square":
                var a = double.Parse(Console.ReadLine());
                var squareArea = a * a;
                Console.WriteLine($"{squareArea:f3}");
                break;
            case "rectangle":
                var sideA = double.Parse(Console.ReadLine());
                var sideB = double.Parse(Console.ReadLine());
                var rectangleArea = sideA * sideB;
                Console.WriteLine($"{rectangleArea:f3}");
                break;
            case "circle":
                var r = double.Parse(Console.ReadLine());
                var circleArea = Math.PI * r * r;
                Console.WriteLine($"{circleArea:f3}");
                break;
            case "triangle":
                var triangleSideA = double.Parse(Console.ReadLine());
                var triangleHeight = double.Parse(Console.ReadLine());
                var triangleArea = triangleSideA * triangleHeight / 2;
                Console.WriteLine($"{triangleArea:f3}");
                break;
        }
    }
}