using System;

class Product
{
    private string name;
    private double price;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Price cannot be negative.");
            }
            else
            {
                price = value;
            }
        }
    }

    // Virtual method
    public virtual double CalculateDiscount()
    {
        return Price;
    }
}

class Electronics : Product
{
    public override double CalculateDiscount()
    {
        double discount = Price * 0.05;
        return Price - discount;
    }
}

class Clothing : Product
{
    public override double CalculateDiscount()
    {
        double discount = Price * 0.15;
        return Price - discount;
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new Electronics();
        product1.Name = "Laptop";
        product1.Price = 20000;

        Product product2 = new Clothing();
        product2.Name = "Jacket";
        product2.Price = 3000;

        Console.WriteLine("Electronics Product: " + product1.Name);
        Console.WriteLine("Final Price after 5% discount = " + product1.CalculateDiscount());

        Console.WriteLine();

        Console.WriteLine("Clothing Product: " + product2.Name);
        Console.WriteLine("Final Price after 15% discount = " + product2.CalculateDiscount());
    }
}