using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        /// <summary>
        /// Facade pattern bir sürü subsystemin kodlarıyla structure ile yada nasıl instance yaratıldığıyla 
        /// değil 
        /// Subsystemlerin birbiri ardına yapılan işlemin ayrı bir katmanda olduğu 
        /// bu katmanın clientlar tarafından kullanıldığı bir patterndir
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
        }
    }
}
