using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    public abstract class Drink
    {
        private bool water;

        public bool Water
        {
            get { return water; }
            set { water = value; }
        }

        public void CheckWater(int waterInMachine)
        {
            if (waterInMachine >= 200)
                water = true;
        }
    }
}
