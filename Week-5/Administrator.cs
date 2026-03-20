using System;
using System.IO;

class FileAudit
{
    static void Main()
    {
        try
        {
            // 1. Accept folder path from user
            Console.Write("Enter folder path: ");
            string folderPath = Console.ReadLine();

            // Check if directory exists
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Invalid directory path!");
                return;
            }

            // Get all files from directory
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] files = dir.GetFiles();

            int fileCount = 0;

            Console.WriteLine("\n--- File Details ---\n");

            // 2. Display file details
            foreach (FileInfo file in files)
            {
                Console.WriteLine("File Name     : " + file.Name);
                Console.WriteLine("File Size     : " + file.Length + " bytes");
                Console.WriteLine("Creation Date : " + file.CreationTime);
                Console.WriteLine("-----------------------------------");

                fileCount++;
            }

            // 3. Display total number of files
            Console.WriteLine("\nTotal Files: " + fileCount);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied to the folder!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine();
    }
}