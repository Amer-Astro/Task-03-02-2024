using Task_03_02_2024;

internal class TrustAccount : Account
{
    public double IntRate { get; set; }

    public int WithdrawCount { get; set; }

    public TrustAccount(string Name = "Unnamed Account", double Balance = 0.0, double IntRate = 0.0) : base(Name, Balance)
    {
        this.IntRate = IntRate;
        WithdrawCount = 0;
    }

    public override bool Deposit(double amount)
    {
        if (amount >= 5000)
        {
            Balance += (amount + IntRate + 50);
            return true;
        }
        else if (amount > 0)
        {
            Balance += (amount + IntRate);
            return true;
        }
        return false;
    }

    public override bool Withdraw(double amount)
    {
        if (amount <= Balance/5 && WithdrawCount < 4)
        {
            Balance -= amount;
            WithdrawCount++;
            return true;
        }
        return false;
    }
}