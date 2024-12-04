using System;

class Account
{

    private string Name;
    private double Balance;

    public Account(string name, double initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        Name = name;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        Balance += amount;
    }

    public void Withdrawal(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");
        if (Balance - amount < 0)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
    }

    public double GetBalance => Balance;

    public override string ToString()
    {
        return $"{Name}: {Balance:C}";
    }
}

class Program
{
    static void Main(string[] args)
    {
 
        Account heikkisAccount = new Account("Heikki's account", 100.00);
        Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

        heikkisAccount.Withdrawal(20);
        Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.GetBalance);

        heikkisSwissAccount.Deposit(200);
        Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.GetBalance);
    }
}
