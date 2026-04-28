
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// ================= Transaction =================
class Transaction
{
    public decimal Amount { get; }
    public string Type { get; }

    public Transaction(decimal amount, string type)
    {
        Amount = amount;
        Type = type;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($" {Type:-12} ${Amount:N2}");
    }
}

// ================= BankAccount =================
class BankAccount
{
    // static (shared)
    private static string _bankName = "Assiut National Bank";
    public static string BankName => _bankName; //fun get return _bankName

    // instance
    public string AccountHolder { get; }

    // private balance
    private decimal __balance;

    // transactions
    private readonly List<Transaction> _transactions = new();
    public ReadOnlyCollection<Transaction> Transactions => _transactions.AsReadOnly();

    // constructor
    public BankAccount(string accountHolder, decimal initialBalance = 0)
    {
        AccountHolder = accountHolder;

        if (initialBalance < 0)
        {
            Console.WriteLine("Initial balance cannot be negative.");
            return;
        }

        __balance = initialBalance;

        if (initialBalance > 0)
            _transactions.Add(new Transaction(initialBalance, "Deposit"));
    }

    // Deposit
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be positive");
            return;
        }

        __balance += amount;
        _transactions.Add(new Transaction(amount, "Deposit"));

        Console.WriteLine($"Deposited {amount:N2}");
    }

    // Withdraw
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be positive");
            return;
        }

        if (amount > __balance)
        {
            Console.WriteLine("Insufficient funds");
            return;
        }

        __balance -= amount;
        _transactions.Add(new Transaction(amount, "Withdrawal"));

        Console.WriteLine($"Withdrew {amount:N2}");
    }

    // Get balance
    public decimal GetBalance()
    {
        return __balance;
    }

    // Print statement
    public void PrintStatement()
    {
        Console.WriteLine("\n╔══════════════════════════════════╗");
        Console.WriteLine("║        Account Statement         ║");
        Console.WriteLine("╠══════════════════════════════════╣");
        Console.WriteLine($"║  Bank   : {BankName,-23}║");
        Console.WriteLine($"║  Holder : {AccountHolder,-23}║");
        Console.WriteLine($"║  Balance: {__balance,-23:N2}║");
        Console.WriteLine("╠══════════════════════════════════╣");
        Console.WriteLine("║          Transactions            ║");
        Console.WriteLine("╠══════════════════════════════════╣");

        foreach (var t in _transactions)
            t.DisplayDetails();

        Console.WriteLine("╚══════════════════════════════════╝");
    }

    // Change bank name
    public static void ChangeBankName(string newName)
    {
        if (newName == "" || newName == null)
        {
            Console.WriteLine("Invalid name");
            return;
        }

        _bankName = newName;
    }
}

// ================= Program =================
class Program
{
    static void Main()
    {
        Console.WriteLine("             ╔════════════════════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("             ║                                                                                                ║");
        Console.WriteLine("             ║                                       Welcome to Our Bank                                      ║");
        Console.WriteLine("             ║                                                                                                ║");
        Console.WriteLine("             ╚════════════════════════════════════════════════════════════════════════════════════════════════╝");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        BankAccount account = new BankAccount(name, 0);

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n╔══════════════════════════════════╗");
            Console.WriteLine("║             MENU                 ║");
            Console.WriteLine("╠══════════════════════════════════╣");
            Console.WriteLine("║  1. Deposit                      ║");
            Console.WriteLine("║  2. Withdraw                     ║");
            Console.WriteLine("║  3. Check Balance                ║");
            Console.WriteLine("║  4. Statement                    ║");
            Console.WriteLine("║  5. Change Bank Name             ║");
            Console.WriteLine("║  6. Exit                         ║");
            Console.WriteLine("╚══════════════════════════════════╝");

            Console.Write("Choose: ");
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Console.Write("Enter amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal d))
                        account.Deposit(d);
                    break;

                case "2":
                    Console.Write("Enter amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal w))
                        account.Withdraw(w);
                    break;

                case "3":
                    Console.WriteLine($"Balance: {account.GetBalance():N2}");
                    break;

                case "4":
                    account.PrintStatement();
                    break;

                case "5":
                    Console.Write("New bank name: ");
                    string newName = Console.ReadLine();
                    BankAccount.ChangeBankName(newName);
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}