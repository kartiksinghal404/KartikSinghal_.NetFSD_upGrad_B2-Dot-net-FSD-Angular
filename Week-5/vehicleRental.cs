using System;

class Vehicle
{
    private string brand;
    private double rentalRatePerDay;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double RentalRatePerDay
    {
        get { return rentalRatePerDay; }
        set
        {
            if (value > 0)
                rentalRatePerDay = value;
            else
                Console.WriteLine("Rental rate must be positive.");
        }
    }

    public virtual double CalculateRental(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days.");
            return 0;
        }

        return rentalRatePerDay * days;
    }
}

class Car : Vehicle
{
    public override double CalculateRental(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days.");
            return 0;
        }

        double total = RentalRatePerDay * days;
        total += 500; // Insurance charge
        return total;
    }
}

class Bike : Vehicle
{
    public override double CalculateRental(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days.");
            return 0;
        }

        double total = RentalRatePerDay * days;
        double discount = total * 0.05; // 5% discount
        return total - discount;
    }
}

class Program
{
    static void Main()
    {
        Vehicle v;

        // Car Example
        v = new Car();
        v.Brand = "Toyota";
        v.RentalRatePerDay = 3000;

        double total = v.CalculateRental(3);
        Console.WriteLine("Car Total Rental = " + total);

        // Bike Example
        v = new Bike();
        v.Brand = "Honda";
        v.RentalRatePerDay = 500;

        double bikeTotal = v.CalculateRental(4);
        Console.WriteLine("Bike Total Rental = " + bikeTotal);
    }
}