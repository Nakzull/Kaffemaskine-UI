using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    public abstract class Appliance
    {
        protected bool power;

        public bool Power
        {
            get { return power; }
            set { power = value; }
        }

        public virtual void PowerOn()
        {
            Power = true;
        }

        public virtual void PowerOff()
        {
            Power = false;
        }
    }
}
