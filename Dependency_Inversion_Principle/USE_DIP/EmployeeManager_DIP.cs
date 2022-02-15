using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.USE_DIP
{
    public class EmployeeManager_DIP : IEmployeeSearchable
    {
        private readonly List<Employee_DIP> _employees;

        public EmployeeManager_DIP()
        {
            _employees = new List<Employee_DIP>();
        }

        public void AddEmployee(Employee_DIP employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee_DIP> GetEmployeesByGenderAndPosition(Gender_DIP gender, Position_DIP position)
            => _employees.Where(emp => emp.Gender_DIP == gender && emp.Position_DIP == position);
    }
}
