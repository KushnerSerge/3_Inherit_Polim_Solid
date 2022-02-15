// See https://aka.ms/new-console-template for more information
using Dependency_Inversion_Principle.NOT_Use_DIP;
using Dependency_Inversion_Principle.USE_DIP;

Console.WriteLine("Hello, World!");

var empManager = new EmployeeManager();
empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });
var stats = new EmployeeStatistics(empManager);
Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");


// using DIP

var empManager_DIP = new EmployeeManager_DIP();
empManager_DIP.AddEmployee(new Employee_DIP { Name_DIP = "Leen", Gender_DIP = Gender_DIP.Female, Position_DIP = Position_DIP.Manager });
empManager_DIP.AddEmployee(new Employee_DIP { Name_DIP = "Mike", Gender_DIP = Gender_DIP.Male, Position_DIP = Position_DIP.Administrator });
var stats_DIP = new EmployeeStatistics_DIP(empManager_DIP);
Console.WriteLine($"Number of female managers in our company is: {stats_DIP.CountFemaleManagers()}");
Console.WriteLine("Some Logic");