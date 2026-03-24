using System;

// Step 1: Singleton Class
public class ConfigurationManager
{
    // Step 2: Static instance (only one object)
    private static ConfigurationManager instance;

    // Lock object for thread safety (optional but good practice)
    private static readonly object lockObj = new object();

    // Step 3: Properties
    public string ApplicationName { get; set; }
    public string Version { get; set; }
    public string DatabaseConnectionString { get; set; }

    // Step 4: Private Constructor (prevents new keyword)
    private ConfigurationManager()
    {
        ApplicationName = "Inventory System";
        Version = "1.0.0";
        DatabaseConnectionString = "Server=localhost;Database=InventoryDB;";
    }

    // Step 5: Public method to get instance
    public static ConfigurationManager GetInstance()
    {
        // Thread-safe Singleton
        if (instance == null)
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
            }
        }
        return instance;
    }
}

// Step 6: Main Program
class Program
{
    static void Main()
    {
        // First call
        ConfigurationManager config1 = ConfigurationManager.GetInstance();

        Console.WriteLine("First Call:");
        Console.WriteLine("App Name: " + config1.ApplicationName);
        Console.WriteLine("Version: " + config1.Version);
        Console.WriteLine("DB: " + config1.DatabaseConnectionString);

        Console.WriteLine();

        // Second call
        ConfigurationManager config2 = ConfigurationManager.GetInstance();

        Console.WriteLine("Second Call:");
        Console.WriteLine("App Name: " + config2.ApplicationName);
        Console.WriteLine("Version: " + config2.Version);
        Console.WriteLine("DB: " + config2.DatabaseConnectionString);

        Console.WriteLine();

        // Check if both instances are same
        if (config1 == config2)
        {
            Console.WriteLine("Both instances are SAME (Singleton works)");
        }
        else
        {
            Console.WriteLine("Instances are DIFFERENT");
        }
    }
}