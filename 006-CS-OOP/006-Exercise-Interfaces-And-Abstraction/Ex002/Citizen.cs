﻿namespace Ex002;

public class Citizen : IPerson, IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

    public string Birthdate { get; set; }
    public string Id { get; set; }

    public string Name { get; set; }
    public int Age { get; set; }
}