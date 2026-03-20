using System;
using System.IO;

class DirectoryAnalyzer
{
    static void Main()
    {
        try
        {
            // Accept root directory path
            Console.Write("Enter root directory path: ");
            string rootPath = Console.ReadLine();

            // Validate directory
            if (!Directory.Exists(rootPath))
            {
                Console.WriteLine("Invalid directory path!");
                return;
            }

            DirectoryInfo rootDir = new DirectoryInfo(rootPath);

            Console.WriteLine("\n=== Project Directory Analysis ===\n");

            // Get all subdirectories
            DirectoryInfo[] subDirs = rootDir.GetDirectories();

            if (subDirs.Length == 0)
            {
                Console.WriteLine("No subdirectories found.");
                return;
            }

            // Table Header
            Console.WriteLine("{0,-25} {1,-15}", "Folder Name", "File Count");
            Console.WriteLine(new string('=', 40));

            int totalFiles = 0;

            // Loop through each directory
            foreach (DirectoryInfo dir in subDirs)
            {
                try
                {
                    FileInfo[] files = dir.GetFiles();

                    Console.WriteLine("{0,-25} {1,-15}", dir.Name, files.Length);

                    totalFiles += files.Length;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("{0,-25} {1,-15}", dir.Name, "Access Denied");
                }
            }

            Console.WriteLine(new string('=', 40));

            // Show total files
            Console.WriteLine("Total Files in all directories: " + totalFiles);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}