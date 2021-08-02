using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibilityPrinciple__SRP_
{
    public class GarageGate:IGarage
    {
        public void OpenGate()
        {
            Console.WriteLine("Gates were Open");
        }
        public void CloseGate()
        {
            Console.WriteLine("Gates Were Close");
        }
    }
}
