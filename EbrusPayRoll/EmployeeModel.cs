using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbrusPayRoll
{
    // Abstraction: Employee is an abstract base class
     abstract class EmployeeModel
    {
        // Encapsulation: Private fields and public properties
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public bool IsActive { get; set; }
        public string PayPeriodStart { get; set; }
        public string PayPeriodEnd { get; set; }
        public string PayDay { get; set; }
        public double RegularHours { get; set; }
        public double OvertimeHours { get; set; }
        public int HourlyRate { get; set; }

        public int OvertimeRate { get; set; }

        // Constructor
        public EmployeeModel(string name, int employeeID)
        {
            Name = name;
            EmployeeID = employeeID;
            IsActive = true;
        }

        // Polymorphism: Abstract methods
        public abstract double CalculateEarnings();
        public abstract double CalculateDeductionsMedicare();
        public abstract double CalculateDeductionsRent();
        public abstract double CalculateDeductionsFood();
    }
}
