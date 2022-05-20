namespace Kaffemaskine_UI
{
    public class PowerOff : MachineState
    {
        Machine machine;

        public PowerOff(Machine newMachine)
        {
            machine = newMachine;
        }

        public void Brewing()
        {
            throw new System.NotImplementedException();
        }

        public void EspressoeCapsuleInserted()
        {
            throw new System.NotImplementedException();
        }

        public void FilterInserted()
        {
            throw new System.NotImplementedException();
        }

        public void PoweredOff()
        {
            throw new System.NotImplementedException();
        }

        public void PoweredOn()
        {
            machine.setMachineState(machine.GetPowerOnState());
        }

        public void ReadyToBrew(Drink drink)
        {
            throw new System.NotImplementedException();
        }

        public void TeabagInserted()
        {
            throw new System.NotImplementedException();
        }
    }
}