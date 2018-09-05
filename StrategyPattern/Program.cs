using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// Strategy Pattern
    /// Changeable and not needed to Refactoring
    /// uses polymorphism, adapted to open-closed princple
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
            */

            MasterProgramme programme;

            programme = new MasterProgramme(new EveningEducation());
            programme.CreateEducationSchedule();

            programme = new MasterProgramme(new OnlineEducation());
            programme.CreateEducationSchedule();
        }
    }
}
