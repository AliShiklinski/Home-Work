namespace Task_2_05._26._2024
{
    public class Program
    {
        public static void Main()
        {
            Car car = new Car(20, 5);
            Truck truck = new Truck(100, 8);


            car.Drive(3);
            car.Drive(4);
            car.Refuel(10);
            car.Drive(5);

            Console.WriteLine();


            truck.Drive(10);
            truck.Drive(20);
            truck.Refuel(50);
            truck.Drive(5);
        }
    }
}
