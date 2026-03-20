using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "log.txt";

        try
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            // Convert string to byte array
            byte[] data = Encoding.UTF8.GetBytes(message + Environment.NewLine);

            // Open file in Append mode
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                fs.Write(data, 0, data.Length);
            }

            Console.WriteLine("✅ Message written successfully!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("❌ Error: Access denied to the file.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("❌ File error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Unexpected error: " + ex.Message);
        }
    }
}