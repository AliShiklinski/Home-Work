namespace Task_1_05._22._2024
{
    public class Product
    {
        
    public int Id { get; }
        public string Name { get; }
        private double _price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                _price = value;
            }
        }

        private int _count;
        public int Count
        {
            get { return count; }
            set
            {
                if (value > 0)
                _count = value;
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

