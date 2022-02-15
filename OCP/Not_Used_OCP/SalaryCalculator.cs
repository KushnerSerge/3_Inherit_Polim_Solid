using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Not_Used_OCP
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<EmployeeRaport> _employeeReports;
        public SalaryCalculator(List<EmployeeRaport> employeeReports)
        {
            _employeeReports = employeeReports;
        }
        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var employee in _employeeReports)
            {
                if (employee.Position == "Engineer")
                {
                    totalSalaries += employee.HourlyRate * employee.WorkingHours * 1.5;
                }
                else if (employee.Position == "Teacher")
                {
                    totalSalaries += employee.HourlyRate * employee.WorkingHours * 1.7;
                } 
            }
            return totalSalaries;
        }
    }
}
