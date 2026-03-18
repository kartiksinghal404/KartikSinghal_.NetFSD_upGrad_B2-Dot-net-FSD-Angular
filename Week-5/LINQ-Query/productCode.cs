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
        // Creating product list
        List<Product> products = new List<Product>()
        {
            new Product { ProductCode = 103, ProductName = "Rice", Category = "Grain" },
            new Product { ProductCode = 101, ProductName = "Soap", Category = "FMCG" },
            new Product { ProductCode = 105, ProductName = "Wheat", Category = "Grain" },
            new Product { ProductCode = 102, ProductName = "Shampoo", Category = "FMCG" },
            new Product { ProductCode = 104, ProductName = "Sugar", Category = "Food" }
        };

        // LINQ Query to sort by ProductCode in ascending order
        var sortedProducts = from p in products
                             orderby p.ProductCode ascending
                             select p;

        Console.WriteLine("Products sorted by Product Code (Ascending):\n");

        foreach (var product in sortedProducts)
        {
            Console.WriteLine("Code: " + product.ProductCode +
                              ", Name: " + product.ProductName +
                              ", Category: " + product.Category);
        }

        Console.ReadLine();
    }
}