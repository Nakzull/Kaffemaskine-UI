using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    //This class handles the grounded coffee interactions with the machine.
    class GroundedCoffeeContainer
    {
        private int groundedCoffee;

        public int GroundedCoffee
        {
            get { return groundedCoffee; }
            set { groundedCoffee = value; }
        }

        //This method adds a specific amount of coffee to the machine.
        public void AddGroundedCoffee(int coffeeGram)
        {
            GroundedCoffee = coffeeGram;
        }
    }
}
