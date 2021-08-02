using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Dependency_Inversion_Principle__DIP_
{
    public class AutomobileController
    {
        IAutomobile iAutomobile;
        public AutomobileController(IAutomobile automobile)
        {
            this.iAutomobile = automobile;
        }
        public void Ignition()
        {
            iAutomobile.Ignition();
        }
        public void Stop()
        {
            iAutomobile.Stop();
        }
    }
}
