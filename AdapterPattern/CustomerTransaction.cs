using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// Adapter
    /// </summary>
    class CustomerTransaction : Customers
    {
        private EngCustomers _engCustomers = new EngCustomers();

        public override void ListCustomers()
        {
            _engCustomers.GetEngCustomers();
        }
    }
}
