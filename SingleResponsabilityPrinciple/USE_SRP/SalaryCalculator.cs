using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple.USE_SRP
{
    public class SalaryCalculator
    {
        
     
        public double CalculateTotalSalaries(List<Employee_SRP> _employeeReports)
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
