
using EbrusPayRoll;

class Program
{
    static void Main()
    {
        PayrollModel payroll = new PayrollModel();

        while (true)
        {
            Console.WriteLine("\n------- Ebrus Tech Payroll System Menu --------");
            Console.WriteLine("\n1. Add Hourly Employee");
            Console.WriteLine("\n2. Generate Payroll Report");
            Console.WriteLine("\n3. Exit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("\nEnter employee name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter employee ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter hourly rate ($): ");
                    double hourlyRate = double.Parse(Console.ReadLine());
                    Console.Write("Enter overtime rate ($): ");
                    double overtimeRate = double.Parse(Console.ReadLine());
                    Console.Write("Enter Regular Worked Hours ($): ");
                    double regularHours = double.Parse(Console.ReadLine());
                    Console.Write("Enter Overtime Worked Hours ($): ");
                    double overtimeHours = double.Parse(Console.ReadLine());

                    EmployeeModel hourlyEmployee = new HourlyEmployeeModel(name, id, hourlyRate, overtimeRate);
                    hourlyEmployee.PayPeriodStart = "2023-10-01";
                    hourlyEmployee.PayPeriodEnd = "2023-10-30";
                    hourlyEmployee.PayDay = "2023-10-31";
                    hourlyEmployee.RegularHours = regularHours;
                    hourlyEmployee.OvertimeHours = overtimeHours;

                    payroll.AddEmployee(hourlyEmployee);
                    Console.WriteLine("Hourly employee added.");
                    break;

                case "2":
                    payroll.GeneratePayrollReport();
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
