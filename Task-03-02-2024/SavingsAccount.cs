using Task_03_02_2024;

internal class SavingsAccount : Account
{
    public SavingsAccount(string Name = "Unnamed Account", double Balance = 0.0, double IntRate = 0.0) : base(Name, Balance)
    {
        this.IntRate = IntRate;
    }

    public double IntRate { get; set; }

    public override bool Withdraw(double amount)
    {
        return base.Withdraw(amount + IntRate);
    }
}