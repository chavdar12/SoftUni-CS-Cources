﻿namespace Ex001;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumptionPerKm)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    protected sealed override double FuelQuantity { get; set; }
    public sealed override double FuelConsumptionPerKm { get; set; }

    public override string Drive(double distance)
    {
        if (FuelQuantity - (FuelConsumptionPerKm + 1.6) * distance >= 0)
        {
            FuelQuantity -= (FuelConsumptionPerKm + 1.6) * distance;
            return $"Truck travelled {distance} km";
        }

        return "Truck needs refueling";
    }

    public override void Refuel(double amount)
    {
        FuelQuantity += amount * 0.95;
    }
}