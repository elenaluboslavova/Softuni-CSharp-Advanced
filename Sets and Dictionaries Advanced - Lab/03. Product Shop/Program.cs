using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string shop = command.Split(", ")[0];
                string product = command.Split(", ")[1];
                double price = double.Parse(command.Split(", ")[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);

                command = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine(shop.Key + "->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
