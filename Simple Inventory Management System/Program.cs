
using Simple_Inventory_Management_System.Entity;
using Simple_Inventory_Management_System.Interface;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Inventory inventory = new Inventory();

            bool exit = false;

            while (!exit)
            {
                MenuOption option = Menu.DisplayMenu();

                switch (option)
                {
                    case MenuOption.AddProduct:
                        Console.Write("Enter product name: ");
                        string productName = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double productPrice = double.Parse(Console.ReadLine());
                        Console.Write("Enter product quantity: ");
                        int productQuantity = int.Parse(Console.ReadLine());
                        inventory.AddProduct(productName, productPrice, productQuantity);
                        break;

                    case MenuOption.DeleteProduct:
                        Console.Write("Enter product name to delete: ");
                        string productToDelete = Console.ReadLine();
                        inventory.DeleteProduct(productToDelete);
                        break;

                    case MenuOption.ViewAllProducts:
                        inventory.ViewAllProducts();
                        break;

                    case MenuOption.SearchProduct:
                        Console.Write("Enter product name to search: ");
                        string productToSearch = Console.ReadLine();
                        var searchedProduct = inventory.SearchProduct(productToSearch);
                        if (searchedProduct != null)
                        {
                            Console.WriteLine($"Product found - Name: {searchedProduct.Name}, Price: {searchedProduct.Price}, Quantity: {searchedProduct.Quantity}");
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;

                    case MenuOption.EditProduct:
                        Console.Write("Enter product name to edit: ");
                        string productToEdit = Console.ReadLine();
                        Console.Write("Enter new name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter new price: ");
                        double newPrice = double.Parse(Console.ReadLine());
                        Console.Write("Enter new quantity: ");
                        int newQuantity = int.Parse(Console.ReadLine());
                        inventory.EditProduct(productToEdit, newName, newPrice, newQuantity);
                        break;

                    case MenuOption.Exit:
                        exit = true;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}