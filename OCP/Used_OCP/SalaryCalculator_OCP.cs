using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Used_OCP
{
    public class SalaryCalculator_OCP
    {
        private readonly IEnumerable<BaseSalaryCalculator> _employeeSalaryCalculation;
        public SalaryCalculator_OCP(IEnumerable<BaseSalaryCalculator> employeeSalaryCalculation)
        {
            _employeeSalaryCalculation = employeeSalaryCalculation;
        }
        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var empSalaryCalc in _employeeSalaryCalculation)
            {
                totalSalaries += empSalaryCalc.CalculateSalary();
            }
            return totalSalaries;
        }
    }
}
