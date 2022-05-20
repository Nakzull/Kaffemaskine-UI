using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    //This class handles the water interactions with the machine.
    class WaterContainer
    {
        private int water;

        public int Water
        {
            get { return water; }
            set { water = value; }
        }
        
        //This method adds a specific amount of water to the machine.
        public void AddWater(int addWater)
        {
            Water = addWater;
        }
    }
}
