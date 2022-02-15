// See https://aka.ms/new-console-template for more information




using SingleResponsabilityPrinciple.NOT_USE_SRP;
using SingleResponsabilityPrinciple.USE_SRP;

// NOT using Single Responsability Principle
var catalog = new EmployeeCatalog();
catalog.AddEntry(new Employee { Id = 1, Name = "Serge", Position = "Developer", WorkingHours = 40, HourlyRate = 42 });
catalog.AddEntry(new Employee { Id = 2, Name = "Sergiu", Position = "Engineer", WorkingHours = 50, HourlyRate = 42 });
var totalSalary = catalog.CalculateTotalSalaries();
Console.WriteLine("Total salary of all employees not using SRP is {0}", totalSalary.ToString());



// Using Single Responsability Principle
var catalog_srp = new EmployeeCatalog_SRP();
catalog_srp.AddEntry(new Employee_SRP { Id = 1, Name = "Serge", Position = "Developer", WorkingHours = 40, HourlyRate = 42 });
catalog_srp.AddEntry(new Employee_SRP { Id = 2, Name = "Sergiu", Position = "Engineer", WorkingHours = 50, HourlyRate = 42 });
Console.WriteLine(catalog_srp.ToString());

var calculator_srp = new SalaryCalculator();
var totalSalary_srp = calculator_srp.CalculateTotalSalaries(catalog_srp.getEmployees());
Console.WriteLine("Total salary of all employees using SRP is {0}", totalSalary_srp.ToString());



