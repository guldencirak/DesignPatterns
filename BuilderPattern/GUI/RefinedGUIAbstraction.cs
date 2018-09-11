using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.GUI
{
    class RefinedGUIAbstraction:GUIAbstract
    {
        public RefinedGUIAbstraction(IGUIImplementor GUIImplementor)
            : base(GUIImplementor)
        {

        }

        public override void Load()
        {
            GUIImplementor.Load();
        }
    }
}
