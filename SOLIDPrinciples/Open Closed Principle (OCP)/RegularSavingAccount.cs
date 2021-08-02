using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Open_Closed_Principle__OCP_
{
    public class RegularSavingAccount : IAccount
    {
        public double CalculateInterest(double balance)
        {
            double interest = (balance * 4) / 100;
            if (balance < 1000) interest -= (balance * 2) / 100;
            if (balance < 50000) interest += (balance * 4) / 100;
            return interest;
        }
    }
}
