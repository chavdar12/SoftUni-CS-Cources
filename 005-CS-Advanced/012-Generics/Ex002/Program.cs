﻿namespace Ex002;

internal class Program
{
    private static void Main()
    {
        var box = new Box<int>();
        box.Add(1);
        box.Add(2);
        box.Add(3);
        Console.WriteLine(box.Remove());
        Console.WriteLine(box.Remove());
        Console.WriteLine(box.Remove());
    }
}