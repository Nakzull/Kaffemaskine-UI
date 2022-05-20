using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    class Tea : Drink, ITeaRequirements
    {
        private bool teabag;

        public bool Teabag
        {
            get { return teabag; }
            set { teabag = value; }
        }

        public void TeabagInserted()
        {
            Teabag = true;
        }
    }
}
