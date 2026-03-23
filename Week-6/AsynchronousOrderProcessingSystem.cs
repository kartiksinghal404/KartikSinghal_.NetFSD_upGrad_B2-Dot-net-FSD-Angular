using System;
using System.Threading.Tasks;

class Program
{
    // Step 1: Verify Payment
    public static async Task VerifyPaymentAsync()
    {
        Console.WriteLine("Verifying payment...");
        await Task.Delay(2000); // simulate delay
        Console.WriteLine("Payment verified \n");
    }

    // Step 2: Check Inventory
    public static async Task CheckInventoryAsync()
    {
        Console.WriteLine("Checking inventory...");
        await Task.Delay(2000); // simulate delay
        Console.WriteLine("Inventory available \n");
    }

    // Step 3: Confirm Order
    public static async Task ConfirmOrderAsync()
    {
        Console.WriteLine("Confirming order...");
        await Task.Delay(2000); // simulate delay
        Console.WriteLine("Order confirmed \n");
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("Order Processing Started...\n");

        // Maintain logical sequence using await
        await VerifyPaymentAsync();
        await CheckInventoryAsync();
        await ConfirmOrderAsync();

        Console.WriteLine("Order processed successfully!");
    }
}
