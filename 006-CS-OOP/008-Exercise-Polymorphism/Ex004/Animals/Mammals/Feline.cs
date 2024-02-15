﻿namespace Ex004.Animals.Mammals;

public abstract class Feline : Mammal
{
    protected Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
    {
        Breed = breed;
    }

    protected virtual string Breed { get; set; }

    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}