using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// Provides the interfaces that unadapdated structures to work together
    /// Uyumsuz interfacelerin birarada çalışmasını sağlar
    /// Adaptee and Target are not compatible
    /// Kodlarına müdahale edemediğimiz yada etmek istenmediğinde adapter patterni kullanılabiliriz
    /// 3.Party kodlar
    /// Eski program kodları
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Target target = new Adapter();

            target.Request();
            */

            Customers customers = new CustomerTransaction();

            customers.ListCustomers();
        }
    }
}
