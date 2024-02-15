﻿namespace Ex008;

public class CustomCollection : IAdd
{
    protected CustomCollection()
    {
        Data = new List<string>(100);
    }

    protected IList<string> Data { get; }

    public virtual int Add(string item)
    {
        const int index = 0;
        Data.Insert(index, item);

        return index;
    }
}