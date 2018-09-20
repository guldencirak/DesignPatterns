using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Employee
{
    class Worker : IEmployee
    {
        public void getEmployee()
        {
            Console.WriteLine("Worker type of employee");
        }
    }
}
