using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    public interface MachineState
    {
        void PoweredOff();
        void PoweredOn();
        void FilterInserted(bool filterIn);
        void EspressoeCapsuleInserted();
        void TeabagInserted();
        void ReadyToBrew(Drink drink);
        void Brewing();
    }
}
