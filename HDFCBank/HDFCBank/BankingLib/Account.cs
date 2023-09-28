namespace BankingLib;

public class Account
{
    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        this.Balance = this.Balance + amount;
    }

    public void Withdraw(double amount)
    {
        this.Balance = this.Balance - amount;
    }
}
