namespace Kaffemaskine_UI
{
    public class PowerOn : MachineState
    {
        Machine machine;

        public PowerOn(Machine newMachine)
        {
            machine = newMachine;
        }

        public void Brewing()
        {
            throw new System.NotImplementedException();
        }

        public void EspressoeCapsuleInserted()
        {
            machine.setMachineState(machine.GetEspressoCapsuleInsertedStats());
        }

        public void FilterInserted()
        {
            machine.setMachineState(machine.GetFilterInsertedState());
        }

        public void PoweredOff()
        {
            machine.setMachineState(machine.GetPowerOffState());
        }

        public void PoweredOn()
        {
            throw new System.NotImplementedException();
        }

        public void ReadyToBrew(Drink drink)
        {
            machine.setMachineState(machine.GetReadyToBrewState());
        }

        public void TeabagInserted()
        {
            machine.setMachineState(machine.GetTeabagInsertedState());
        }
    }
}