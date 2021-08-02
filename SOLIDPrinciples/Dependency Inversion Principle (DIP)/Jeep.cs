using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Dependency_Inversion_Principle__DIP_
{
    public class Jeep : IAutomobile
    {
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }
        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
    }
}
