using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.GUI
{
    abstract class GUIAbstract
    {
        private IGUIImplementor _GUIImplementor;

        internal IGUIImplementor GUIImplementor
        {
            get { return _GUIImplementor; }
            set { _GUIImplementor = value; }
        }

        public GUIAbstract(IGUIImplementor GUIImplementor)
        {
            _GUIImplementor = GUIImplementor;
        }

        public abstract void Load();
    }
}
