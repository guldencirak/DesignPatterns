using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.OrderPayment
{
    class OrderReceipt
    {
        private Order _order = new Order();
        private Payment _payment = new Payment();
        private PrintReceipt _print = new PrintReceipt();


        public void CreateOrderReceipt()
        {
            _order.CreateOrder();
            _payment.DoPayment();
            _print.Print();
        }
    }
}
