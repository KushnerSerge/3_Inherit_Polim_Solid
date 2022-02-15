// See https://aka.ms/new-console-template for more information
using OCP.Not_Used_OCP;
using OCP.Used_OCP;

var employeeRaports = new List<EmployeeRaport>
    {
        new EmployeeRaport {Id = 1, Name = "Sergiu", Position = "Engineer", HourlyRate  = 30.5, WorkingHours = 200 },
        new EmployeeRaport {Id = 2, Name = "Serge", Position = "Teacher", HourlyRate  = 20, WorkingHours = 220 }
       
    };
var calculator = new SalaryCalculator(employeeRaports);

Console.WriteLine($"Sum of all the employee salaries is {calculator.CalculateTotalSalaries()} dollars");

// OCP implementation

var EmployeeCalculus = new List<BaseSalaryCalculator>
        {
            new TeacherSalaryCalculator(new EmployeeRaport_OCP {Id = 1, Name = "Sergiu", Position = "Engineer", HourlyRate = 30.5, WorkingHours = 200 }),
            new EngineerSalaryCalculator(new EmployeeRaport_OCP {Id = 2, Name = "Serge", Position = "Teacher", HourlyRate = 20, WorkingHours = 220 }),
           
        };
var calculator_OCP = new SalaryCalculator_OCP(EmployeeCalculus);
Console.WriteLine($"Sum of all the developer salaries is {calculator_OCP.CalculateTotalSalaries()} dollars");