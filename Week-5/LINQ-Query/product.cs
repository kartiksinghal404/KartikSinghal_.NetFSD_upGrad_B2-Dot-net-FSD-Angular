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
            new Product{ ProductCode = 103, ProductName = "Soap", Category = "FMCG", Mrp = 20 },
            new Product{ ProductCode = 104, ProductName = "Shampoo", Category = "FMCG", Mrp = 25 }
        };

        bool allBelow30 = products.All(p => p.Mrp < 30);

        Console.WriteLine("Are all products below Rs.30? " + allBelow30);
    }
}