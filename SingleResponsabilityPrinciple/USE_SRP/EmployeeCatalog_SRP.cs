
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple.USE_SRP
{
    public class EmployeeCatalog_SRP
    {
        private readonly List<Employee_SRP> _entries;
        public EmployeeCatalog_SRP()
        {
            _entries = new List<Employee_SRP>();
        }
        public void AddEntry(Employee_SRP entry) => _entries.Add(entry);
        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);
        public List<Employee_SRP> getEmployees() => _entries;


        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Name: {x.Name}, Position: {x.Position}, WorkingHours: {x.WorkingHours}, HourlyRate: {x.HourlyRate}"));

    }
}
