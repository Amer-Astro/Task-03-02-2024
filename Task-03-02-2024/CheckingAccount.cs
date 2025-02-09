using Task_03_02_2024;

internal class CheckingAccount : Account
{
    double fee = 1.5;

    public CheckingAccount(string Name = "Unnamed Account", double Balance = 0.0) : base(Name, Balance)
    {
        
    }

    public override bool Withdraw(double amount)
    {
        return base.Withdraw(amount + fee);
    }
}