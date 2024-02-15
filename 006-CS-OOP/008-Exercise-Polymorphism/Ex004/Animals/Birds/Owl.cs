﻿using Ex004.Food;

namespace Ex004.Animals.Birds;

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override string ProduceSound()
    {
        return "Hoot Hoot";
    }

    public override void Eat(Food.Food food)
    {
        if (food.GetType().Name == nameof(Meat))
        {
            var gainWeight = food.Quantity * 0.25;
            Weight += gainWeight;
            FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}