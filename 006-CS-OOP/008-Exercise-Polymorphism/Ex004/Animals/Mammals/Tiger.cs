﻿using Ex004.Food;

namespace Ex004.Animals.Mammals;

public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion,
        breed)
    {
    }

    public override string ProduceSound()
    {
        return "ROAR!!!";
    }

    public override void Eat(Food.Food food)
    {
        if (food.GetType().Name == nameof(Meat))
        {
            var gainWeight = food.Quantity * 1.00;
            Weight += gainWeight;
            FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}