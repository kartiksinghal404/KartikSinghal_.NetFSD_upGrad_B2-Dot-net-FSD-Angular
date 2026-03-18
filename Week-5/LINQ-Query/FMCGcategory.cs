using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int ProductCode { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public double Mrp { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product{ ProductCode = 101, ProductName = "Rice", Category = "Grain", Mrp = 60 },
            new Product{ ProductCode = 102, ProductName = "Wheat", Category = "Grain", Mrp = 50 },
            new Product{ ProductCode = 103, ProductName = "Soap", Category = "FMCG", Mrp = 40 },
            new Product{ ProductCode = 104, ProductName = "Shampoo", Category = "FMCG", Mrp = 120 },
            new Product{ ProductCode = 105, ProductName = "Toothpaste", Category = "FMCG", Mrp = 95 }
        };

        var highestPriceProduct = products
            .Where(p => p.Category == "FMCG")
            .OrderByDescending(p => p.Mrp)
            .FirstOrDefault();

        Console.WriteLine("Highest Price Product in FMCG Category:");
        Console.WriteLine("Code: " + highestPriceProduct.ProductCode);
        Console.WriteLine("Name: " + highestPriceProduct.ProductName);
        Console.WriteLine("Category: " + highestPriceProduct.Category);
        Console.WriteLine("MRP: " + highestPriceProduct.Mrp);
    }
}