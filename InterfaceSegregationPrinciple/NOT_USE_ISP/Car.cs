using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.NOT_USE_ISP
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
