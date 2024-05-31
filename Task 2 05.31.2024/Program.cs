using System;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Mercedes", "E200", CarType.Sedan);
        Car car2 = new Car("BMW", "F10", CarType.Sedan);

        Console.WriteLine(car1);
        Console.WriteLine(car2);


    }
}
