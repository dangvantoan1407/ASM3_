using ASM3.asm3;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.BalanceChanged += new BankAccount.BalanceChangedEventHandler(HandleBalanceChanged);


        account.Deposit(1000);
        account.Withdraw(500);


    }
    static void HandleBalanceChanged(double newBalance)
    {
        Console.WriteLine($"Balance changed. New balance: {newBalance}");
    }
}
