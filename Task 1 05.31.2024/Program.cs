class Program
{
    static void Main(string[] args)
    {
       
        Room room1 = new Room("Single", 50, 1);
        Room room2 = new Room("Double", 80, 2);

      
        Hotel hotel = new Hotel("Example Hotel");
        hotel.AddRoom(room1);
        hotel.AddRoom(room2);

    
        try
        {
            hotel.MakeReservation(1); 
            hotel.MakeReservation(1);
            hotel.MakeReservation(nulleption);
            hotel.MakeReservation(3); 
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error occurred: {e.Message}");
        }
    }
}
