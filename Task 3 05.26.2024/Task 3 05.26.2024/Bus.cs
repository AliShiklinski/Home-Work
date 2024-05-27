namespace Task_3_05._26._2024
{
    public class Bus : Vehicle
    {
        private const double AirConditioningConsumptionWithPassengers = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {
        }

        public override void Drive(int distance, bool hasPassengers = false)
        {
            double consumption = hasPassengers ? FuelConsumptionPerKm + AirConditioningConsumptionWithPassengers : FuelConsumptionPerKm;
            double neededFuel = distance * consumption;
            if (FuelQuantity >= neededFuel)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Bus traveled {distance} km. Fuel left: {FuelQuantity} liters.");
            }
            else
            {
                double minFuelNeeded = neededFuel - FuelQuantity;
                Console.WriteLine($"Insufficient gasoline. Need at least {minFuelNeeded} more liters to travel {distance} km.");
            }
        }
    }
}
