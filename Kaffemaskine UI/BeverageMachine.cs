using System;
using System.Collections.Generic;
using System.Text;

namespace Kaffemaskine_UI
{
    //This clase will handle making beverages for the user and will manage all the other classes needed to produce each drink.
    class BeverageMachine : Appliance
    {
        WaterContainer watercontainer = new WaterContainer();
        GroundedCoffeeContainer groundedCoffeeContainer = new GroundedCoffeeContainer();
        TeaContainer teaContainer = new TeaContainer();
        EspressoContainer espressoContainer = new EspressoContainer();
        Filter filter = new Filter();
        private bool brewing;

        public bool Brewing
        {
            get { return brewing; }
            set { brewing = value; }
        }

        private bool cupFull;

        public bool CupFull
        {
            get { return cupFull; }
            set { cupFull = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        //This method checks if all the prequisites are met and then makes a cup of coffee.
        public void MakeCoffee()
        {
            if (Power == true)
            {
                if (CupFull == false)
                {
                    if (filter.FilterIn == true)
                    {
                        if (filter.FilterUsed == false)
                        {
                            if (watercontainer.Water >= 200)
                            {
                                if (groundedCoffeeContainer.GroundedCoffee >= 14)
                                {
                                    watercontainer.Water -= 200;
                                    groundedCoffeeContainer.GroundedCoffee -= 14;
                                    filter.DirtyFilter();
                                    CupFull = true;
                                    Status = "Making coffee...";
                                    MachineBrewing();
                                }
                                else
                                    Status = "Need more\n   coffee";
                            }
                            else
                                Status = "Need more\n    water";
                        }
                        else
                            Status = "Need clean\n   filter";
                    }
                    else
                        Status = "No filter";
                }
                else
                    Status = "Cup already\n        full";
            }
        }

        //This method checks if all the prequisites are met and then makes a cup of tea.
        public void MakeTea()
        {
            if (Power == true)
            {
                if (CupFull == false)
                {
                    if (teaContainer.Teabag == true)
                    {
                        if (watercontainer.Water >= 200)
                        {
                            watercontainer.Water -= 200;
                            teaContainer.RemoveTeabag();
                            CupFull = true;
                            Status = "Making tea...";
                            MachineBrewing();
                        }
                        else
                            Status = "Need more\n    water";
                    }
                    else
                        Status = "No teabag";
                }
                else
                    Status = "Cup already\n        full";
            }
        }

        //This method checks if all the prequisites are met and then makes a cup of espresso.
        public void MakeEspresso()
        {
            if (Power == true)
            {
                if (CupFull == false)
                {
                    if (espressoContainer.CapsuleIsUsed == false)
                    {
                        if (espressoContainer.EspressoCapsule == true)
                        {
                            if (watercontainer.Water >= 200)
                            {
                                watercontainer.Water -= 200;
                                espressoContainer.CapsuleUsed();
                                Status = "Making espresso...";
                                MachineBrewing();
                            }
                            else
                                Status = "Need more\n   water";
                        }
                        else
                            Status = "No capsule\n  inserted";
                    }
                    else
                        Status = "Remove old\n  capsule";
                }
                else
                    Status = "Cup already\n        full";
            }
        }

        //This method adds a new espresso capsule to the machine and sets the current status of capsule to unused.
        public void AddEspressoCapsule()
        {
            espressoContainer.AddEspressoCapsule();
            espressoContainer.CapsuleUnused();
        }
        //This method removes the espresso capsule from the machine and sets the current status of capsule to unused.
        public void RemoveEspressoCapsule()
        {
            espressoContainer.RemoveEspressoCapsule();
            espressoContainer.CapsuleUnused();
        }

        //This method lets the user add water to the container.
        public void AddWater(int addWater)
        {
            watercontainer.AddWater(addWater);
        }

        //This method removes the filter and sets it's status to clean.
        public void RemoveFilter()
        {
            filter.RemoveFilter();
            filter.CleanFilter();
        }

        //This method checks if there is a filter and if not inserts a new one. 
        public void AddFilter()
        {
            if (filter.FilterIn == false)
            {
                filter.AddFilter();
            }
        }

        //This method lets the user add coffee.
        public void AddGroundedCoffee(int coffeegram)
        {
            groundedCoffeeContainer.AddGroundedCoffee(coffeegram);
        }

        //This method adds a new teabag.
        public void AddTeabag()
        {
            teaContainer.AddTeabag();
        }

        //This method sets the cup to being empty.
        public void TakeCup()
        {
            CupFull = false;
        }

        //This method sets the machines state to brewing.
        public void MachineBrewing()
        {
            Brewing = true;
        }

        //This method sets the machines state to not brewing.
        public void MachineNotBrewing()
        {
            Brewing = false;
        }
    }
}
