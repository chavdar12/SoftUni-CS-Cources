﻿namespace Ex001;

public class Person
{
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FirstName { get; }
    private string LastName { get; }
    public int Age { get; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
}