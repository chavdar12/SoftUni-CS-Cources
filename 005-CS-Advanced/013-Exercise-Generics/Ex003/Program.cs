﻿namespace Ex003;

internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var @string = new Box<string>(Console.ReadLine());
            Console.WriteLine(@string);
        }
    }
}