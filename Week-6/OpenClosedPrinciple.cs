using System;

// Step 1: Create Interface
public interface IDiscountStrategy
{
    double CalculateDiscount(double amount);
}

// Step 2: Implement Discount Classes

// Regular Customer - 5%
public class RegularCustomerDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double amount)
    {
        return amount * 0.05;
    }
}

// Premium Customer - 10%
public class PremiumCustomerDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double amount)
    {
        return amount * 0.10;
    }
}

// VIP Customer - 20%
public class VipCustomerDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double amount)
    {
        return amount * 0.20;
    }
}

// Step 3: Discount Calculator
public class DiscountCalculator
{
    private IDiscountStrategy _discountStrategy;

    public DiscountCalculator(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public double GetFinalPrice(double amount)
    {
        double discount = _discountStrategy.CalculateDiscount(amount);
        return amount - discount;
    }
}

// Step 4: Main Program
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Amount:");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nSelect Customer Type:");
        Console.WriteLine("1. Regular");
        Console.WriteLine("2. Premium");
        Console.WriteLine("3. VIP");

        int choice = Convert.ToInt32(Console.ReadLine());

        IDiscountStrategy strategy = null;

        switch (choice)
        {
            case 1:
                strategy = new RegularCustomerDiscount();
                break;
            case 2:
                strategy = new PremiumCustomerDiscount();
                break;
            case 3:
                strategy = new VipCustomerDiscount();
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        DiscountCalculator calculator = new DiscountCalculator(strategy);
        double finalPrice = calculator.GetFinalPrice(amount);

        Console.WriteLine($"\nFinal Price after discount: {finalPrice}");
    }
}