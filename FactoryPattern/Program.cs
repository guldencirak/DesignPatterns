using FactoryPattern.Employee;
using FactoryPattern.Name;
using FactoryPattern.Report;
using FactoryPattern.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        /// <summary>
        /// Factory pattern 
        /// Creational
        /// Client objectin nasıl yaratıldığını bilmesine gerek yoktur
        /// 
        /// Factory Method
        /// Abstract Method
        /// 
        /// Factory Method:
        /// Aynı interface yapısını uygulayan sınıfların üretiminden sorumludur
        /// 
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
            TamIsim isim = IsimFabrikasi.getirIsim("cirak, gulden");
            string ad = isim.adGetir();
            string soyad = isim.soyadGetir();
            */

            /*
            ReportFactory factoryOfReport = new ReportFactory();

            IReport tReport = factoryOfReport.factoryOfReport(ReportType.Table);
            tReport.CreateReport();

            IReport gReport = factoryOfReport.factoryOfReport(ReportType.Graphical);
            gReport.CreateReport();
            */

            /*
            VehicleFactory factory = new VehicleFactory();

            IVehicle vehicleCar = factory.ProduceVehicle(VehicleType.Car);
            vehicleCar.DisplayInfo();

            IVehicle vehicleMotorcycle = factory.ProduceVehicle(VehicleType.Motorcycle);
            vehicleMotorcycle.DisplayInfo();

             */

            EmployeeFactory employeeFactory = new EmployeeFactory();

            IEmployee manager = employeeFactory.ProduceEmployee(EmployeeType.Manager);
            manager.getEmployee();

            IEmployee intern = employeeFactory.ProduceEmployee(EmployeeType.Intern);
            intern.getEmployee();

            Console.ReadLine();
        }
    }
}
