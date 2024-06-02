
namespace PayRoll.Model
{
    class Payroll
    {
        public List<Employee> employees = new List<Employee>();



        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void GeneratePayrollReport()
        {
            ;
            Console.WriteLine("Employee Payroll Report");
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("| Employee ID | Name         | Active | Pay Period            | Hours          | Wages           | Deductions     |");
            Console.WriteLine("|             |              |        | Start Date - End Date | Regular - Overtime | Regular - Overtime | Medicare - Rent - Food |");
            Console.WriteLine("==========================================================================================");

            foreach (var employee in employees)
            {
                double earnings = employee.CalculateEarnings();
                double deductions = employee.CalculateDeductions();

                Console.WriteLine($"| {employee.EmployeeID,11} | {employee.Name,-12} | {employee.IsActive,-6} | " +
                    $"{employee.PayPeriodStart} - {employee.PayPeriodEnd,-16} | " +
                    $"{employee.RegularHours:F2} - {employee.OvertimeHours:F2} | " +
                    $"{employee.HourlyRate:F2} - {employee.OvertimeRate:F2} | " +
                    $"{deductions,7:F2} - {earnings,8:F2} |");
            }

            Console.WriteLine("==========================================================================================");
        }
    }
}