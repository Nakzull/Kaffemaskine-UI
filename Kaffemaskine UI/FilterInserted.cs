namespace Kaffemaskine_UI
{
    public class FilterInserted : MachineState
    {
        Machine machine;


        public FilterInserted(Machine newMachine)
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
            
        }

        public void TeabagInserted()
        {
            throw new System.NotImplementedException();
        }

        void MachineState.FilterInserted(bool filterIn)
        {
            throw new System.NotImplementedException();
        }
    }
}