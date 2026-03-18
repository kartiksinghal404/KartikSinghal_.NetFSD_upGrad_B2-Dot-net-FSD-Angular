using System;

// Custom Exception Class
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

// BankAccount Class
class BankAccount
{
    private double balance;

    // Constructor
    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException("Withdrawal amount exceeds available balance");
        }

        balance -= amount;
        Console.WriteLine("Withdrawal successful. Remaining Balance: " + balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter Account Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Withdrawal Amount: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            BankAccount account = new BankAccount(balance);

            account.Withdraw(withdrawAmount);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction Completed.");
        }
    }
}