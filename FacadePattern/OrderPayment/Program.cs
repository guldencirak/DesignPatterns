using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.OrderPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderReceipt orderReceipt = new OrderReceipt();
            orderReceipt.CreateOrderReceipt();
        }
    }
}
