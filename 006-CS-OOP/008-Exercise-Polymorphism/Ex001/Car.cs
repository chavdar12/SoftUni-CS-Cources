﻿namespace Ex001;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumptionPerKm)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    protected sealed override double FuelQuantity { get; set; }
    public sealed override double FuelConsumptionPerKm { get; set; }

    public override string Drive(double distance)
    {
        if (!(FuelQuantity - (FuelConsumptionPerKm + 0.9) * distance >= 0)) return "Car needs refueling";
        FuelQuantity -= (FuelConsumptionPerKm + 0.9) * distance;
        return $"Car travelled {distance} km";
    }

    public override void Refuel(double amount)
    {
        FuelQuantity += amount;
    }
}