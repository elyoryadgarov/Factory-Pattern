﻿namespace FactoryPattern;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Car Drive");
    }
}