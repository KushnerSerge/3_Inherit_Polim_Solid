using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Used_OCP
{

    public class EngineerSalaryCalculator : BaseSalaryCalculator
    {
        public EngineerSalaryCalculator(EmployeeRaport_OCP report)
    : base(report)
        {
        }
        public override double CalculateSalary() => EmployeeReport.HourlyRate * EmployeeReport.WorkingHours * 1.7;
    }
}
