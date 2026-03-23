using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    // Sales Report
    static void GenerateSalesReport()
    {
        Console.WriteLine("Sales Report Started...");
        Thread.Sleep(3000); // simulate delay
        Console.WriteLine("Sales Report Completed ");
    }

    // Inventory Report
    static void GenerateInventoryReport()
    {
        Console.WriteLine("Inventory Report Started...");
        Thread.Sleep(2000); // simulate delay
        Console.WriteLine("Inventory Report Completed ");
    }

    // Customer Report
    static void GenerateCustomerReport()
    {
        Console.WriteLine("Customer Report Started...");
        Thread.Sleep(2500); // simulate delay
        Console.WriteLine("Customer Report Completed ");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Report Generation Started...\n");

        // Run tasks concurrently
        Task t1 = Task.Run(() => GenerateSalesReport());
        Task t2 = Task.Run(() => GenerateInventoryReport());
        Task t3 = Task.Run(() => GenerateCustomerReport());

        // Wait for all tasks to complete
        Task.WaitAll(t1, t2, t3);

        Console.WriteLine("\nAll reports generated successfully!");
    }
}