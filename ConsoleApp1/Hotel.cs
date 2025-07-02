namespace ConsoleApp1
{
    public class Hotel
    {
        private List<Room> rooms = new List<Room>
        {
            new Room(1, "SingleBed", 25),
            new Room(2, "DoubleBed", 50),
            new Room(3, "Royal", 100),
            new Room(4, "Simple", 5),
            new Room(5, "SingleBed", 25),
            new Room(6, "SingleBed", 25)
        };

        public static decimal Income = 0;


        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public void RemoveRoom(int nr)
        {
            Room roomToRemove = null;
            foreach (var room in rooms)
            {
                if (room.RoomNumber == nr)
                {
                    roomToRemove = room;
                    break;
                }
            }
            if (roomToRemove != null)
            {
                rooms.Remove(roomToRemove);
            }
            else
            {
                throw new KeyNotFoundException($"Room with nr: {nr} not found");
            }
        }

        public Room FindRoom(string type)
        {
            foreach (var room in rooms)
            {
                if (room.RoomType == type)
                {
                    return room;
                }
            }
            throw new KeyNotFoundException($"Room with type: {type} not found");

        }

        public void Book(int nr)
        {
            Room roomToBook = null;
            foreach (var room in rooms)
            {
                if (room.RoomNumber == nr)
                {
                    roomToBook = room;
                    break;
                }
            }
            if (roomToBook != null)
            {
                if (!roomToBook.IsOccupied)
                {
                    roomToBook.CheckIn();
                    Income += roomToBook.Price;
                }
            }
            else
            {
                throw new KeyNotFoundException($"Room with nr: {nr} not found");
            }
        }

        public void FreeRoom(int nr)
        {
            Room roomToFree = null;
            foreach (var room in rooms)
            {
                if (room.RoomNumber == nr)
                {
                    roomToFree = room;
                    break;
                }
            }
            if (roomToFree != null)
            {
                if (roomToFree.IsOccupied)
                {
                    roomToFree.CheckOut();
                }
            }
            else
            {
                throw new KeyNotFoundException($"Room with nr: {nr} not found");
            }
        }

        public void ShowAvailable()
        {
            foreach (var room in rooms)
            {
                if (!room.IsOccupied)
                {
                    Console.WriteLine($"Room: {room.RoomNumber} is availabel!");
                }
            }
        }
    }
    public class Room
    {

        public int RoomNumber { get; private set; }
        public string RoomType { get; private set; }
        public decimal Price { get; private set; }
        public bool IsOccupied { get; private set; }

        public Room(int roomNumber, string roomType, decimal price)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            Price = price;
        }

        public void CheckIn()
        {
            if (IsOccupied)
            {
                throw new ArgumentException("Room is already occupied!");
            }

            IsOccupied = true;
        }

        public void CheckOut()
        {
            if (!IsOccupied)
            {
                throw new ArgumentException("Room is already empty!");
            }

            IsOccupied = false;
        }
    }
}
