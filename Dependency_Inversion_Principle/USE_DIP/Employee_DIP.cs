using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.USE_DIP
{
    public enum Gender_DIP
    {
        Male,
        Female
    }

    public enum Position_DIP
    {
        Administrator,
        Manager,
        Executive
    }
    public class Employee_DIP
    {
        public string Name_DIP { get; set; }
        public Gender_DIP Gender_DIP { get; set; }
        public Position_DIP Position_DIP { get; set; }
    }
}
