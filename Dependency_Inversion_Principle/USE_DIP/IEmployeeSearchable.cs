using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.USE_DIP
{


    public interface IEmployeeSearchable
    {
        IEnumerable<Employee_DIP> GetEmployeesByGenderAndPosition(Gender_DIP gender, Position_DIP position);
    }
}
