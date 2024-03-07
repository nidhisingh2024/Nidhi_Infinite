using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
}

class Items

{
    static void Main(string[] args)
    {
        // This will take 10 products as an input
        Product[] products = new Product[10];

        for (int i = 0; i < 10; i++)
        {
            products[i] = new Product();

            Console.WriteLine($"Enter details for product {i + 1}:");
            Console.Write("Product Id: ");
            products[i].ProductId = int.Parse(Console.ReadLine());

            Console.Write("Product Name: ");
            products[i].ProductName = Console.ReadLine();

            Console.Write("Price: ");
            products[i].Price = double.Parse(Console.ReadLine());
        }

        // Not using built in functions for sorting
        for (int i = 0; i < products.Length - 1; i++)
        {
            for (int j = i + 1; j < products.Length; j++)
            {
                if (products[i].Price > products[j].Price)
                {
                    // this will swap the products if price is high
                    Product temp = products[i];
                    products[i] = products[j];
                    products[j] = temp;
                }
            }
        }

        // final result
        Console.WriteLine("\nSorted Products based on Price:");
        foreach (var product in products)
        {
            Console.WriteLine($"Product Id: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
            Console.ReadLine();
        }
    }
}
