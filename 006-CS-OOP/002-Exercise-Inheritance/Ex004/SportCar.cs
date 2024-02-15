﻿namespace Ex004;

public class SportCar : Car
{
    private const double DefaultFuelConsumption = 10;

    public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
    {
    }

    protected override double FuelConsumption => DefaultFuelConsumption;
}