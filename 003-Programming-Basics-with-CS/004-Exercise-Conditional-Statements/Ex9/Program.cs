namespace Ex9;

internal class Program
{
    private static void Main(string[] args)
    {
        var poolVolume = int.Parse(Console.ReadLine());
        var firstPipe = int.Parse(Console.ReadLine());
        var secondPipe = int.Parse(Console.ReadLine());
        var hoursThatWorkerIsOut = double.Parse(Console.ReadLine());

        var firstPipeIncome = hoursThatWorkerIsOut * firstPipe;
        var secondPipeIncome = hoursThatWorkerIsOut * secondPipe;
        var totalWaterFromPipes = firstPipeIncome + secondPipeIncome;

        if (totalWaterFromPipes <= poolVolume)
        {
            var poolVolumePercents = totalWaterFromPipes / poolVolume * 100;
            var firstPipePercents = firstPipeIncome / totalWaterFromPipes * 100;
            var secondPipePercents = secondPipeIncome / totalWaterFromPipes * 100;
            Console.WriteLine(
                $"The pool is {poolVolumePercents:f2}% full. Pipe 1: {firstPipePercents:f2}%. Pipe 2: {secondPipePercents:f2}%.");
        }
        else if (totalWaterFromPipes > poolVolume)
        {
            var overflowLiters = totalWaterFromPipes - poolVolume;
            Console.WriteLine($"For {hoursThatWorkerIsOut} the pool overflows with {overflowLiters:f2} liters.");
        }
    }
}