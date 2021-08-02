using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Interface_Segregation_Principle__ISP_
{
    public class OnlineOrder:Ishoping,IPayForShoping
    {
        public void PlaceOrder()
        {
            Console.WriteLine("The Order is Place.");
        }
        public void OnlinePayment()
        {
            Console.WriteLine("Payment for Order is Done.");
        }
    }
}
