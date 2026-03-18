using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int ProductCode { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product { ProductCode = 101, ProductName = "Rice", Category = "Grain" },
            new Product { ProductCode = 102, ProductName = "Soap", Category = "FMCG" },
            new Product { ProductCode = 103, ProductName = "Wheat", Category = "Grain" },
            new Product { ProductCode = 104, ProductName = "Shampoo", Category = "FMCG" },
            new Product { ProductCode = 105, ProductName = "Oil", Category = "Grocery" }
        };

        // LINQ Query to sort products by Category in ascending order
        var sortedProducts = from p in products
                             orderby p.Category ascending
                             select p;

        Console.WriteLine("Products sorted by Category (Ascending):");

        foreach (var product in sortedProducts)
        {
            Console.WriteLine(product.ProductCode + " - " + product.ProductName + " - " + product.Category);
        }
    }
}