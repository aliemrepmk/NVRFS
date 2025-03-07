namespace HW3
{
    // Q1
    public class Employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public double employeeSalary { get; set; }
        public string employeeDepartment { get; set; }

        public virtual double CalculateBonus(double employeeSalary)
        {
            return 0;
        }
    }
}
