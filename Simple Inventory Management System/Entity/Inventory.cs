using System.Collections.Generic;

namespace Simple_Inventory_Management_System.Entity
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string name, double price, int quantity)
        {
            products.Add(new Product(name, price, quantity));
        }

        public void SearchProduct(string name)
        {
            var product = products.Find(p => p.Name == name);

            if (product != null)
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            else
                Console.WriteLine("Product not found!");
        }
    }
}
