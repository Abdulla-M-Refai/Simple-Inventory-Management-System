
namespace Simple_Inventory_Management_System.Interface
{
    public class Menu
    {
        public static MenuOption DisplayMenu()
        {
            Console.WriteLine("  Inventory Management System Menu");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Delete Product");
            Console.WriteLine("3. View All Products");
            Console.WriteLine("4. Search Product");
            Console.WriteLine("5. Edit Product");
            Console.WriteLine("6. Exit");
            Console.Write("Please enter your choice: ");

            if (Enum.TryParse(Console.ReadLine(), out MenuOption option))
            {
                return option;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return DisplayMenu();
            }
        }
    }
}
