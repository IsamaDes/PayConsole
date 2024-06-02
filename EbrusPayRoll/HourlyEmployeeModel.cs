using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbrusPayRoll
{
     class HourlyEmployeeModel : EmployeeModel
    {
        public double HourlyRate { get; set; }
        public double OvertimeRate { get; set; } 

        private List<HourlyEmployeeModel> rates = new List<HourlyEmployeeModel>();

        // Constructor
        public HourlyEmployeeModel(string name, int employeeID, double hourlyRate, double overtimeRate)
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
        public override double CalculateDeductionsMedicare()
        {
            double grossPay = CalculateEarnings();
            double medicare = grossPay * 0.02; // 2%
            return medicare;   
        }

        // Polymorphism: Override CalculateDeductions
        public override double CalculateDeductionsRent()
        {
            double grossPay = CalculateEarnings();
            double rent = grossPay * 0.05;     // 5%
            return rent;  
        }

        // Polymorphism: Override CalculateDeductions
        public override double CalculateDeductionsFood()
        {
            double grossPay = CalculateEarnings();         
            double food = grossPay * 0.03;     // 3%
            return food;
        }
    }
}
