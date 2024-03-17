
namespace Simple_Inventory_Management_System.Entity
{
    public class Product
    {
        private string name;

        private double price;

        private int quantity;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or empty.");

                name = value;
            }
        }

        public double Price
        {
            get 
            { 
                return price; 
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");

                price = value;
            }
        }

        public int Quantity
        {
            get 
            { 
                return quantity; 
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Quantity cannot be negative.");
                
                quantity = value;
            }
        }

        public void Edit(String name, double price, int quantity)
        {
            Name = name; 
            Price = price; 
            Quantity = quantity;
        }
    }
}
