namespace Task_2_05._26._2024
{
    public class Car : Vehicle
    {

        private const double AirConditioningConsumption = 0.5;

        public Car(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm + AirConditioningConsumption)
        {
        }

        public override void Drive(int distance)
        {
            double neededFuel = distance * FuelConsumptionPerKm;
            if (FuelQuantity >= neededFuel)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Car traveled {distance} km. Fuel left: {FuelQuantity} liters.");
            }
            else
            {
                double minFuelNeeded = neededFuel - FuelQuantity;
                Console.WriteLine($"Insufficient gasoline. Need at least {minFuelNeeded} more liters to travel {distance} km.");
            }
        }

        public override void Refuel(double amount)
        {
            FuelQuantity += amount;
            Console.WriteLine($"Car refueled with {amount} liters. Total fuel: {FuelQuantity} liters.");
        }
    }
}

