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
            new Product{ Id = 1, Name = "Rice", Category = "Grain"},
            new Product{ Id = 2, Name = "Wheat", Category = "Grain"},
            new Product{ Id = 3, Name = "Milk", Category = "Dairy"},
            new Product{ Id = 4, Name = "Sugar", Category = "FMCG"},
            new Product{ Id = 5, Name = "Barley", Category = "Grain"}
        };

        var result = from p in products
                     where p.Category == "Grain"
                     select p;

        Console.WriteLine("Products in Grain Category:");

        foreach (var item in result)
        {
            Console.WriteLine(item.Id + " " + item.Name + " " + item.Category);
        }
    }
}