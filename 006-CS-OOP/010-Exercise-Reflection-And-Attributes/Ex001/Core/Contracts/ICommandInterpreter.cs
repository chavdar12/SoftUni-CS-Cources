﻿namespace Ex001.Core.Contracts;

public interface ICommandInterpreter
{
    string Read(string args);
}