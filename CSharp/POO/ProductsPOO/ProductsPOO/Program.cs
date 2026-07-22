using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsPOO.Entitites;

namespace ProductsPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} date:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char option = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (option == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsfee));
                }
                else if (option == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (option == 'u')
                {
                    DateTime manufatureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufatureDate));
                }
            }
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
