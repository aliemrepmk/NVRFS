namespace HW3
{
    // Q2
    public class CheckingAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest.");
        }
    }
}
