﻿namespace Ex002;

public class MyRequiredAttribute : MyValidationAttribute
{
    public override bool IsValid(object obj)
    {
        return obj != null;
    }
}