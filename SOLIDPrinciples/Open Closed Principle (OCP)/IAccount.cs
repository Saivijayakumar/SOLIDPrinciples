using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Open_Closed_Principle__OCP_
{
    public interface IAccount
    {
        double CalculateInterest(double bal);
    }
}
