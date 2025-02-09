using Task_03_02_2024;

internal class TrustAccount : Account
{
    public TrustAccount(string Name = "Unnamed Account", double Balance = 0.0, double InterestRata = 0.0) : base(Name, Balance)
    {
        this.InterestRata = InterestRata;
    }

    public double InterestRata { get; set; }
}