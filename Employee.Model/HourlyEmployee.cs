using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.Employees
{
    // Inheritance: HourlyEmployee is a derived class of Employee
    class HourlyEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public double OvertimeRate { get; set; }

        private List<HourlyEmployee> rates = new List<HourlyEmployee>();

        // Constructor
        public HourlyEmployee(string name, int employeeID, double hourlyRate, double overtimeRate)
            : base(name, employeeID)
        {
            HourlyRate = hourlyRate;
            OvertimeRate = overtimeRate;

        }

        // Polymorphism: Override CalculateEarnings
        public override double CalculateEarnings()
        {
            return (RegularHours * HourlyRate) + (OvertimeHours * OvertimeRate);
        }

        // Polymorphism: Override CalculateDeductions
        public override double CalculateDeductions()
        {
            double grossPay = CalculateEarnings();
            double medicare = grossPay * 0.02; // 2%
            double rent = grossPay * 0.05;     // 5%
            double food = grossPay * 0.03;     // 3%

            return medicare + rent + food;
        }
    }
}
