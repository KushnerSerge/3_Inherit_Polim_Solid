﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.NOT_Use_DIP
{
    public class EmployeeStatistics
    {
        private readonly EmployeeManager _empManager;

        public EmployeeStatistics(EmployeeManager empManager)
        {
            _empManager = empManager;
        }

        public int CountFemaleManagers() =>
      _empManager.Employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager);
    }
}

