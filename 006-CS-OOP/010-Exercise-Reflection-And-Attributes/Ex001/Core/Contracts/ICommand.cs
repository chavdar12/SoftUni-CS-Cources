﻿namespace Ex001.Core.Contracts;

public interface ICommand
{
    string Execute(string[] args);
}