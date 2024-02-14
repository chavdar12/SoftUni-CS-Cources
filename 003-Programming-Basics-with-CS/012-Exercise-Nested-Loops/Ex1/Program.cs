namespace Ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        var pyramidNumber = int.Parse(Console.ReadLine());

        var currentNumberInPyramid = 1;
        var flag = false;

        for (var i = 1; i <= pyramidNumber; i++)
        {
            for (var j = 1; j <= i; j++)
            {
                if (currentNumberInPyramid > pyramidNumber)
                {
                    flag = true;
                    break;
                }

                Console.Write($"{currentNumberInPyramid} ");
                currentNumberInPyramid++;
            }

            if (flag) break;
            Console.WriteLine();
        }
    }
}