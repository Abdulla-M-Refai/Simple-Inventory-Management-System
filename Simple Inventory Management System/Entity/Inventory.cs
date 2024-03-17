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

        public void DeleteProduct(string name)
        {
            var product = products.Find(p => p.Name == name);

            if (product != null)
                products.Remove(product);
            else
                Console.WriteLine("Product not found!");
        }

        public void ViewAllProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }

        public Product? SearchProduct(string name)
        {
            return products.Find(p => p.Name == name);
        }

        public void EditProduct(string productName, string newName, double newPrice, int newQuantity)
        {
            Product? product = SearchProduct(productName);
            
            if(product == null)
            {
                Console.WriteLine("product not found");
                return;
            }

            if(SearchProduct(newName) == null)
            {
                Console.WriteLine($"Product with name: {newName} already exist");
                return;
            }

            product.Edit(newName, newPrice, newQuantity);
        }
    }
}
