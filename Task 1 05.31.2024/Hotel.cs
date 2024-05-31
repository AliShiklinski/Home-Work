using System.Collections.Generic;

public class Hotel
{
    public string Name { get; }
    private List<Room> _rooms;

    public Hotel(string name)
    {
        Name = name;
        _rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        _rooms.Add(room);
    }

    public void MakeReservation(int? roomId)
    {
        try
        {
            if (!roomId.HasValue)
            {
                throw new NullReferenceException("Room ID cannot be null.");
            }

            Room room = _rooms.Find(r => r.Id == roomId);

            if (room == null)
            {
                throw new ArgumentException("Room not found with the given ID.");
            }

            if (!room.IsAvailable)
            {
                throw new NotAvailableException();
            }

            room.IsAvailable = false;
            Console.WriteLine("Reservation made successfully.");
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (NotAvailableException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
