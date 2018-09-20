using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Employee
{
    public enum EmployeeType
    {
        Worker,
        Manager,
        Intern
    }

    class EmployeeFactory
    {
        private IEmployee employee;

        public IEmployee ProduceEmployee(EmployeeType type)
        {
            IEmployee employee = null;

            switch (type)
            {
                case EmployeeType.Worker:
                    employee = new Worker();
                    break;
                case EmployeeType.Manager:
                    employee = new Manager();
                    break;
                case EmployeeType.Intern:
                    employee = new Intern();
                    break;
                default:
                    break;
            }

            return employee;
        }
    }
}
