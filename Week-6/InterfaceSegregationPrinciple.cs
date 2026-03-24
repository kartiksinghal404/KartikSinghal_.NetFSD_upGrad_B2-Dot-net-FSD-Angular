using System;

// Step 1: Create Small Interfaces

public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public interface IFax
{
    void Fax();
}

// Step 2: Basic Printer (only Print)

public class BasicPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Basic Printer: Printing document...");
    }
}

// Step 3: Advanced Printer (Print + Scan + Fax)

public class AdvancedPrinter : IPrinter, IScanner, IFax
{
    public void Print()
    {
        Console.WriteLine("Advanced Printer: Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Advanced Printer: Scanning document...");
    }

    public void Fax()
    {
        Console.WriteLine("Advanced Printer: Sending fax...");
    }
}

// Step 4: Main Program

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BASIC PRINTER ===");
        IPrinter basicPrinter = new BasicPrinter();
        basicPrinter.Print();

        Console.WriteLine();

        Console.WriteLine("=== ADVANCED PRINTER ===");
        AdvancedPrinter advancedPrinter = new AdvancedPrinter();
        advancedPrinter.Print();
        advancedPrinter.Scan();
        advancedPrinter.Fax();
    }
}