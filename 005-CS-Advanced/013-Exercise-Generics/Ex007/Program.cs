﻿namespace Ex007;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var list = new List<Box<string>>();
        for (var i = 0; i < n; i++)
        {
            var currentBox = new Box<string>(Console.ReadLine());
            list.Add(currentBox);
        }

        var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Swap(list, indexes[0], indexes[1]);
        Console.WriteLine(string.Join(Environment.NewLine, list));
    }

    private static void Swap<T>(List<Box<T>> list, int idx1, int idx2)
    {
        (list[idx1], list[idx2]) = (list[idx2], list[idx1]);
    }
}