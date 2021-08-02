using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibilityPrinciple__SRP_
{
    public class Garage
    {
        IGarage garage;
        public Garage(IGarage garage)
        {
            this.garage = garage;
        }
        public void OpenForService()
        {
            garage.OpenGate();
        }
        public void DoServiec()
        {
            Console.WriteLine("The service is Done");
        }
        public void closeGarage()
        {
            garage.CloseGate();
        }
    }
}
