﻿namespace Ex002;

public abstract class MyValidationAttribute : Attribute
{
    public abstract bool IsValid(object obj);
}