using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    class Coffee : Drink, ICoffeeRequirements
    {
        private bool coffeePowder;

        public bool CoffeePowder
        {
            get { return coffeePowder; }
            set { coffeePowder = value; }
        }

        private bool filter;

        public bool Filter
        {
            get { return filter; }
            set { filter = value; }
        }

        public void FilterCheck(bool filterAdded)
        {
            if (filterAdded == true)
                Filter = true;
        }

        public void GroundedCoffee(int coffeeInMachine)
        {
            if (coffeeInMachine > 14)
                CoffeePowder = true;
        }
    }
}
