using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    public class Machine : MachineState
    {
        Drink drink = new Coffee();
        MachineState powerOff;
        MachineState powerOn;
        MachineState filterInserted;
        MachineState espressoCapsuleInserted;
        MachineState teabagInserted;
        MachineState readyToBrew;
        MachineState brewing;

        MachineState machinestate;

        WaterContainer watercontainer = new WaterContainer();
        GroundedCoffeeContainer groundedCoffeeContainer = new GroundedCoffeeContainer();
        TeaContainer teaContainer = new TeaContainer();
        EspressoContainer espressoContainer = new EspressoContainer();
        Filter filter = new Filter();


        public Machine()
        {
            powerOff = new PowerOff(this);
            powerOn = new PowerOn(this);
            filterInserted = new FilterInserted(this);
            espressoCapsuleInserted = new EspressoCapsuleInserted(this);
            teabagInserted = new TeabagInserted(this);
            readyToBrew = new ReadyToBrew(this);
            brewing = new Brewing(this);

            machinestate = powerOff;
        }

        public void setMachineState(MachineState newMachineState)
        {
            machinestate = newMachineState;
        }

        public void PowerOff()
        {
            machinestate.PoweredOff();
        }

        public void PowerOn()
        {
            machinestate.PoweredOn();
        }

        public void FilterInserted()
        {
            machinestate.FilterInserted(filter.FilterIn);
        }

        public void EspressoCapsuleInserted()
        {
            machinestate.EspressoeCapsuleInserted();
        }

        public void TeabagInserted()
        {
            machinestate.TeabagInserted();
        }

        public void ReadyToBrew(Drink drink)
        {
            machinestate.ReadyToBrew(drink);
        }

        public void Brewing()
        {
            machinestate.Brewing();
        }

        public MachineState GetPowerOffState()
        {
            return powerOff;
        }

        public MachineState GetPowerOnState()
        {
            return powerOn;
        }

        public MachineState GetFilterInsertedState()
        {
            return filterInserted;
        }

        public MachineState GetEspressoCapsuleInsertedStats()
        {
            return espressoCapsuleInserted;
        }

        public MachineState GetTeabagInsertedState()
        {
            return teabagInserted;
        }

        public MachineState GetReadyToBrewState()
        {
            return readyToBrew;
        }

        public MachineState GetBrewingState()
        {
            return brewing;
        }
    }
}
