using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbrusPayRoll
{
    class PayrollModel
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        public void AddEmployee(EmployeeModel employee)
        {
            employees.Add(employee);
        }
        public void GeneratePayrollReport()
        {
            
            Console.WriteLine("Employee Payroll Report");
            Console.WriteLine("===============================================================================================================================================");
            Console.WriteLine("| Name         | Active |       Pay Period      |          Hours          |                Wages                   |        Deductions      |");
            Console.WriteLine("|              |        | Start Date - End Date | Regular - Overtime      | Regular Rate | Overtime Rate | Gross Pay| | Net Pay| Medicare | Rent | Food |");
            Console.WriteLine("================================================================================================================================================");
            
            foreach (var employee in employees)
            {
                double earnings = employee.CalculateEarnings();
                double deductionsMedicare = employee.CalculateDeductionsMedicare();
                double deductionsRent = employee.CalculateDeductionsRent();
                double deductionsFood = employee.CalculateDeductionsFood();

                Console.WriteLine($"| {employee.Name,-12} | {employee.IsActive,-6} | " +
                    $"{employee.PayPeriodStart} | {employee.PayPeriodEnd,-16} | " +
                    $"{employee.RegularHours:F2} | {employee.OvertimeHours:F2} | " +
                    $"{employee.HourlyRate:F2} | {employee.OvertimeRate:F2} | {earnings:F2} | " +
                    $"{deductionsMedicare,9:F2} | {deductionsRent,10:F2} | {deductionsFood,11:F2}|");
            }

            Console.WriteLine("==========================================================================================");
        }
    }
}
