using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.NOT_Use_DIP
{
    public class EmployeeManager
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> Employees => _employees;
    }
}
