namespace Task_3_05._26._2024
{
    public class Program
    {

        public static void Main()
        {
            Car car = new Car(20, 5, 50);
            Truck truck = new Truck(100, 8, 300);
            Bus bus = new Bus(40, 6, 100);

            car.Drive(3);
            car.Drive(4);
            car.Refuel(10);
            car.Drive(5);

            Console.WriteLine();

            truck.Drive(10);
            truck.Drive(20);
            truck.Refuel(50);
            truck.Drive(5);

            Console.WriteLine();

            bus.Drive(10, true); 
            bus.Drive(5, false); 
            bus.Refuel(60);
            bus.Drive(10, true);
        }
    }
}
