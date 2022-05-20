using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    class Espresso : Drink, IEspressoRequirements
    {
        private bool capsule;

        public bool Capsule
        {
            get { return capsule; }
            set { capsule = value; }
        }

        public void EspressoCapsule()
        {
            Capsule = true;
        }
    }
}
