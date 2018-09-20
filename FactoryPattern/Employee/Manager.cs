using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Employee
{
    class Manager : IEmployee
    {
        public void getEmployee()
        {
            Console.WriteLine("Manager type of employee");
        }
    }
}
