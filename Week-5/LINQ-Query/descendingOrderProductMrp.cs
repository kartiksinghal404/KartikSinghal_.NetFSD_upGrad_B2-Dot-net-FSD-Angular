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
            new Product { ProductCode = 101, ProductName = "Rice", Category = "Grain", Mrp = 60 },
            new Product { ProductCode = 102, ProductName = "Soap", Category = "FMCG", Mrp = 40 },
            new Product { ProductCode = 103, ProductName = "Wheat", Category = "Grain", Mrp = 50 },
            new Product { ProductCode = 104, ProductName = "Shampoo", Category = "FMCG", Mrp = 120 },
            new Product { ProductCode = 105, ProductName = "Oil", Category = "Grocery", Mrp = 150 }
        };

        // LINQ Query to sort products by MRP in descending order
        var sortedProducts = from p in products
                             orderby p.Mrp descending
                             select p;

        Console.WriteLine("Products sorted by MRP (Descending):");

        foreach (var product in sortedProducts)
        {
            Console.WriteLine(product.ProductCode + " - " + product.ProductName + " - " + product.Category + " - " + product.Mrp);
        }
    }
}