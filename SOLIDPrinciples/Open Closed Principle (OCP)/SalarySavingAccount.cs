using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Open_Closed_Principle__OCP_
{
    public class SalarySavingAccount:IAccount
    {
        public double CalculateInterest(double balance)
        {
            double interest = (balance * 5) / 100;
            return interest;
        }
    }
}
