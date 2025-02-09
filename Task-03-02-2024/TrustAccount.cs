using Task_03_02_2024;

internal class TrustAccount : Account
{
    public double IntRate { get; set; }

    public TrustAccount(string Name = "Unnamed Account", double Balance = 0.0, double IntRate = 0.0) : base(Name, Balance)
    {
        this.IntRate = IntRate;
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

    int count = 0;
    public override bool Withdraw(double amount)
    {
        if (amount <= Balance/5 && count < 4)
        {
            count++;
            Balance -= amount;
            return true;
        }
        return false;
    }
}