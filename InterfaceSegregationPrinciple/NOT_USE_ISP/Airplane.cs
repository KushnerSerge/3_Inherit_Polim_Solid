using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.NOT_USE_ISP
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
