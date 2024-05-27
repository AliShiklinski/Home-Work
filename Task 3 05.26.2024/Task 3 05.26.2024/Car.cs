namespace Task_3_05._26._2024
{
    public class Car : Vehicle
    {

        private const double AirConditioningConsumption = 0.5;

        public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm + AirConditioningConsumption, tankCapacity)
        {
        }

        public override void Drive(int distance, bool hasPassengers = false)
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
    }
}

