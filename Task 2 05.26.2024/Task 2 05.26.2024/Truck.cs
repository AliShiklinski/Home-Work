namespace Task_2_05._26._2024
{
    public class Truck : Vehicle
    {

        private const double AirConditioningConsumption = 1.5;
        private const double RefuelEfficiency = 0.95;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm + AirConditioningConsumption)
        {
        }

        public override void Drive(int distance)
        {
            double neededFuel = distance * FuelConsumptionPerKm;
            if (FuelQuantity >= neededFuel)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Truck traveled {distance} km. Fuel left: {FuelQuantity} liters.");
            }
            else
            {
                double minFuelNeeded = neededFuel - FuelQuantity;
                Console.WriteLine($"Insufficient gasoline. Need at least {minFuelNeeded} more liters to travel {distance} km.");
            }
        }

        public override void Refuel(double amount)
        {
            double actualAmount = amount * RefuelEfficiency;
            FuelQuantity += actualAmount;
            Console.WriteLine($"Truck refueled with {amount} liters (effective: {actualAmount} liters). Total fuel: {FuelQuantity} liters.");
        }
    }
}

