using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Employee
{
    class Intern : IEmployee
    {
        public void getEmployee()
        {
            Console.WriteLine("Intern type of employee");
        }
    }
}
