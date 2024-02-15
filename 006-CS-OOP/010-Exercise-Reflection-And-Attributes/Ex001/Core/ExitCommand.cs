﻿using Ex001.Core.Contracts;

namespace Ex001.Core;

public class ExitCommand : ICommand
{
    public string Execute(string[] args)
    {
        Environment.Exit(0);
        return null;
    }
}