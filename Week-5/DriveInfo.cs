using System;
using System.IO;

class DiskMonitor
{
    static void Main()
    {
        try
        {
            // Get all drives
            DriveInfo[] drives = DriveInfo.GetDrives();

            Console.WriteLine("=== Disk Storage Information ===\n");

            foreach (DriveInfo drive in drives)
            {
                // Check if drive is ready
                if (drive.IsReady)
                {
                    Console.WriteLine($"Drive Name      : {drive.Name}");
                    Console.WriteLine($"Drive Type      : {drive.DriveType}");
                    Console.WriteLine($"Total Size (GB) : {drive.TotalSize / (1024 * 1024 * 1024)}");
                    Console.WriteLine($"Free Space (GB) : {drive.AvailableFreeSpace / (1024 * 1024 * 1024)}");

                    // Calculate free space percentage
                    double freePercent = (double)drive.AvailableFreeSpace / drive.TotalSize * 100;

                    Console.WriteLine($"Free Space (%)  : {freePercent:F2}%");

                    // Warning if below 15%
                    if (freePercent < 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("⚠ WARNING: Low Disk Space!");
                        Console.ResetColor();
                    }

                    Console.WriteLine("-----------------------------------");
                }
                else
                {
                    Console.WriteLine($"Drive {drive.Name} is not ready.");
                    Console.WriteLine("-----------------------------------");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}