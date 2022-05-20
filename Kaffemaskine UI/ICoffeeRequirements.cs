using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    interface ICoffeeRequirements
    {
        void GroundedCoffee(int coffee);
        void FilterCheck(bool filter);
    }
}
