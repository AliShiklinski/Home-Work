namespace Task_3_05._26._2024
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double FuelConsumptionPerKm { get; protected set; }
        public double TankCapacity { get; protected set; }

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
        }

        public abstract void Drive(int distance, bool hasPassengers = false);

        public virtual void Refuel(double amount)
        {
            if (FuelQuantity + amount > TankCapacity)
            {
                Console.WriteLine($"{amount} liters of gasoline does not fit in the tank.");
            }
            else
            {
                FuelQuantity += amount;
                Console.WriteLine($"Refueled with {amount} liters. Total fuel: {FuelQuantity} liters.");
            }
        }
    }

}

