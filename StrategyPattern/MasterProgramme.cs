using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MasterProgramme
    {
        private MasterEducation _masterEducation;

        public MasterProgramme(MasterEducation masterEducation)
        {
            _masterEducation = masterEducation;
        }

        public void CreateEducationSchedule()
        {
            _masterEducation.Education();
        }
    }
}
