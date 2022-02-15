using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple.NOT_USE_SRP
{
    public class EmployeeCatalog
    {
        private readonly List<Employee> _entries;
        public EmployeeCatalog()
        {
            _entries = new List<Employee>();
        }
        public void AddEntry(Employee entry) => _entries.Add(entry);
        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var employee in _entries)
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


        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Name: {x.Name}, Position: {x.Position}, WorkingHours: {x.WorkingHours}, HourlyRate: {x.HourlyRate}"));


    }
}

