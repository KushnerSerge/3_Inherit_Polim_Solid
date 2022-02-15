using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Used_OCP
{
    public abstract class BaseSalaryCalculator
    {
        protected EmployeeRaport_OCP EmployeeReport { get; private set; }
        public BaseSalaryCalculator(EmployeeRaport_OCP employeeReport)
        {
            EmployeeReport = employeeReport;
        }
        public abstract double CalculateSalary();
    }
}
