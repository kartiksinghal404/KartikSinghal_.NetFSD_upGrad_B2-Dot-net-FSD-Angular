using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Soap", Category = "FMCG" },
            new Product { Id = 2, Name = "Laptop", Category = "Electronics" },
            new Product { Id = 3, Name = "Shampoo", Category = "FMCG" },
            new Product { Id = 4, Name = "Mobile", Category = "Electronics" }
        };

        // LINQ Query
        var result = from p in products
                     where p.Category == "FMCG"
                     select p;

        // Display products
        foreach (var item in result)
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Category: {item.Category}");
        }
    }
}