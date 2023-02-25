using ImportedProducts.Entities;
using System.Globalization;

namespace ImportedProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new();

            Console.WriteLine("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.Clear();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Comon, used or imported? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                switch (type)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine());
                        ImportedProduct iProduct = new(name, price, fee);
                        products.Add(iProduct);
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        UsedProduct uProduct = new(name, price, date);
                        products.Add(uProduct);
                        break;
                    default:
                        Product product = new(name, price);
                        products.Add(product);
                        break;
                }
            }
            Console.WriteLine("PRICE TAGS:");
            Console.WriteLine("-----------");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}