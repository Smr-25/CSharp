namespace DelegateAndEventDemo;

public delegate void BalanceChangedHandler(decimal balance);

public class BankAccount
{
    public decimal Balance { get; private set; }

    public event BalanceChangedHandler? BalanceChanged;

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive.");
        }

        Balance += amount;
        BalanceChanged?.Invoke(Balance);
    }
}

public static class Program
{
    public static void Main()
    {
        BankAccount account = new();

        BalanceChangedHandler printBalance = balance =>
            Console.WriteLine($"New balance: {balance:C}");

        account.BalanceChanged += printBalance;
        account.Deposit(50m);
        account.Deposit(25m);

        account.BalanceChanged -= printBalance;
        account.Deposit(10m);

        Console.WriteLine($"Final balance: {account.Balance:C}");
    }
}
