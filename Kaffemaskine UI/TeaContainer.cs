using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    //This class handles the interactions with the teabag.
    class TeaContainer
    {
        private bool teabag;

        public bool Teabag
        {
            get { return teabag; }
            set { teabag = value; }
        }

        //This method adds a new teabag to the cup.
        public void AddTeabag()
        {
            Teabag = true;
        }

        //This method removes the used teabag from the cup.
        public void RemoveTeabag()
        {
            Teabag = false;
        }
    }
}
