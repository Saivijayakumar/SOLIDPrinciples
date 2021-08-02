using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Interface_Segregation_Principle__ISP_
{
    public class OfflineOrder:Ishoping
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Order is Placed.Pay at the time of delivery");
        }

    }
}
