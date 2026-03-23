using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Configure Trace Listener (log file)
        Trace.Listeners.Clear();
        Trace.Listeners.Add(new TextWriterTraceListener("OrderLog.txt"));
        Trace.AutoFlush = true;

        Console.WriteLine("Order Processing Started...\n");

        try
        {
            ValidateOrder();
            ProcessPayment();
            UpdateInventory();
            GenerateInvoice();

            Console.WriteLine("\nOrder processed successfully!");
            Trace.TraceInformation("Order processed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
            Trace.WriteLine("ERROR: " + ex.Message);
        }

        Console.WriteLine("\nTrace log saved to OrderLog.txt");
    }

    static void ValidateOrder()
    {
        Trace.WriteLine("Step 1: Validating Order...");
        Console.WriteLine("Validating Order...");
    }

    static void ProcessPayment()
    {
        Trace.WriteLine("Step 2: Processing Payment...");
        Console.WriteLine("Processing Payment...");

        // Simulate error (for debugging)
        // Uncomment to test failure
        // throw new Exception("Payment Failed!");
    }

    static void UpdateInventory()
    {
        Trace.WriteLine("Step 3: Updating Inventory...");
        Console.WriteLine("Updating Inventory...");
    }

    static void GenerateInvoice()
    {
        Trace.WriteLine("Step 4: Generating Invoice...");
        Console.WriteLine("Generating Invoice...");
    }
}