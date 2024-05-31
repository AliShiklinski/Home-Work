using System;

public enum CarType
{
    Sport,
    SUV,
    Sedan
}

public class Car
{
    private static int nextId = 1;

    public int Id { get; }
    public string Brand { get; }
    public string Model { get; }
    public CarType Type { get; }

    public Car(string brand, string model, CarType type)
    {
        Id = nextId++;
        Brand = brand;
        Model = model;
        Type = type;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Brand: {Brand}, Model: {Model}, Type: {Type}";
    }
}
