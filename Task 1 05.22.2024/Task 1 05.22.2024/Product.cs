namespace Task_1_05._22._2024
{
    public class Product
    {
        
    public int Id { get; }
        public string Name { get; }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                new ArgumentException("Price cannot be negative.");
                price = value;
            }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set
            {
                if (value < 0)
                new ArgumentException("Count cannot be negative.");
                count = value;
            }
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}

