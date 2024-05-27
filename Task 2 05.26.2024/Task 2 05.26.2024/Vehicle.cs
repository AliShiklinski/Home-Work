namespace Task_2_05._26._2024
{
    public abstract class Vehicle
    {

        public double FuelQuantity { get; protected set; }
        public double FuelConsumptionPerKm { get; protected set; }

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public abstract void Drive(int distance);

        public abstract void Refuel(double amount);
    }

}
