using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    //This class handles the filter interactions with the machine.
    class Filter
    {
        private bool filterIn;

        public bool FilterIn
        {
            get { return filterIn; }
            set { filterIn = value; }
        }

        private bool filterUsed;

        public bool FilterUsed
        {
            get { return filterUsed; }
            set { filterUsed = value; }
        }

        //This method adds a filter to the machine.
        public void AddFilter()
        {
            FilterIn = true;
        }
        //This method removes the filter from the machine.
        public void RemoveFilter()
        {
            FilterIn = false;
        }

        //This method sets the filter to being dirty.
        public void DirtyFilter()
        {
            FilterUsed = true;
        }
        
        //This method sets the filter to being clean.
        public void CleanFilter()
        {
            FilterUsed = false;
        }
    }
}
