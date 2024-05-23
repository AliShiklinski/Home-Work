namespace Task_1_05._22._2024
{
    public class Book : Product
    {
        
    public string Genre { get; }

        public Book(int id, string name, double price, string genre)
            : base(id, name, price)
        {
            Genre = genre;
        }
    }

}

