using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.USE_DIP
{
    public class EmployeeStatistics_DIP
    {
        private readonly IEmployeeSearchable _emp;

        public EmployeeStatistics_DIP(IEmployeeSearchable emp)
        {
            _emp = emp;
        }

        public int CountFemaleManagers() =>
        _emp.GetEmployeesByGenderAndPosition(Gender_DIP.Female, Position_DIP.Manager).Count();
    }
}
