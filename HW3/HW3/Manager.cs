namespace HW3
{
    // Q1
    public class Manager : Employee
    {
        public int teamSize { get; set; }

        public override double CalculateBonus(double employeeSalary)
        {
            return ((employeeSalary) * (0.2));
        }
    }
}
