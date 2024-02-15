﻿namespace Ex004.Animals.Birds;

public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override string ProduceSound()
    {
        return "Cluck";
    }

    public override void Eat(Food.Food food)
    {
        var gainWeight = food.Quantity * 0.35;
        Weight += gainWeight;
        FoodEaten += food.Quantity;
    }
}