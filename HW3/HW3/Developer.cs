namespace HW3
{
    // Q1
    public class Developer : Employee
    {
        public string about { get; set; }

        public override double CalculateBonus(double employeeSalary)
        {
            return ((employeeSalary) * (0.1));
        }
    }
}
