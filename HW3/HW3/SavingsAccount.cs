namespace HW3
{
    // Q2
    public class SavingsAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Interest: " + (accountBalance * 0.05));
        }
    }
}
