public class Room
{
    private static int _idCounter = 1;

    public int Id { get; }
    public string Name { get; }
    public double Price { get; }
    public int PersonCapacity { get; }
    public bool IsAvailable { get; private set; } = true;

    public Room(string name, double price, int personCapacity)
    {
        Id = _idCounter++;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Room ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Person Capacity: {PersonCapacity}");
        Console.WriteLine($"Available: {IsAvailable}");
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}
