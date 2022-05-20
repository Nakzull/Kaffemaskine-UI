using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    //This clasa handles the espresso interactions with the machine.
    class EspressoContainer
    {
        private bool espressoCapsule;

        public bool EspressoCapsule
        {
            get { return espressoCapsule; }
            set { espressoCapsule = value; }
        }

        private bool capsuleIsUsed;

        public bool CapsuleIsUsed
        {
            get { return capsuleIsUsed; }
            set { capsuleIsUsed = value; }
        }

        //This method adds a espresso capsule to the machine.
        public void AddEspressoCapsule()
        {
            EspressoCapsule = true;
        }
        //This method removes the espresso capsule from the machine.
        public void RemoveEspressoCapsule()
        {
            EspressoCapsule = false;
        }
        //This method sets the capsule to be used.
        public void CapsuleUsed()
        {
            CapsuleIsUsed = true;
        }
        //This method sets the capsule to be unused.
        public void CapsuleUnused()
        {
            CapsuleIsUsed = false;
        }
    }
}
