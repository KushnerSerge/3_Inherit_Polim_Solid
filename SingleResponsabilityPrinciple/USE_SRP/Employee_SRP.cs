using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple.USE_SRP
{
    public class Employee_SRP
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
