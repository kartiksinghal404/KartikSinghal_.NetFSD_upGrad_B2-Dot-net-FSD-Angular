using System;
using System.Threading.Tasks;

class Program
{
    // Asynchronous method to simulate file logging
    public static async Task WriteLogAsync(string message)
    {
        Console.WriteLine($"Start Writing: {message}");

        // Simulate file writing delay (like saving to disk)
        await Task.Delay(2000);

        Console.WriteLine($"Finished Writing: {message}");
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("Logging Started...\n");

        // Calling async methods without blocking main thread
        Task log1 = WriteLogAsync("User Logged In");
        Task log2 = WriteLogAsync("File Uploaded");
        Task log3 = WriteLogAsync("Error Occurred");

        Console.WriteLine("Main thread is still running...\n");

        // Wait for all logging tasks to complete
        await Task.WhenAll(log1, log2, log3);

        Console.WriteLine("\nAll logs written successfully!");
    }
}