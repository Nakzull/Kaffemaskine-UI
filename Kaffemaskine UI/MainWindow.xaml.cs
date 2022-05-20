using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kaffemaskine_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string done = "Done";
        BeverageMachine beverageMachine = new BeverageMachine();
        BackgroundWorker backgroundWorker = new BackgroundWorker();

        public MainWindow()
        {
            beverageMachine.PowerOff();
            backgroundWorker.DoWork += (s, e) => { Thread.Sleep(5000); };
            backgroundWorker.RunWorkerCompleted += (s, e) => { Display.Content = done; };
        }

        //This method turns the machine off and changes visibility for the on/off buttons and removes all text from the display.
        private void PowerOnButton_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.PowerOff();
            PowerButtonOff.Visibility = Visibility.Visible;
            PowerButtonOn.Visibility = Visibility.Hidden;
            Display.Content = "";
        }

        //This method turns the machine off and changes visibility for the on/off buttons.
        private void PowerOffButton_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.PowerOn();
            PowerButtonOn.Visibility = Visibility.Visible;
            PowerButtonOff.Visibility = Visibility.Hidden;
        }

        //This method handles the interactions for the coffee button.
        private void CoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.MakeCoffee();
            BeverageStatus();
        }

        //This method handles the interactions for the tea button.
        private void TeaButton_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.MakeTea();
            BeverageStatus();
        }

        //This method handles the interactions for the espresso button.
        private void EspressoButton_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.MakeEspresso();
            BeverageStatus();
        }

        //This method handles the interactions for the cup button and hides the teastring.
        private void Cup_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.TakeCup();
            TeabagString.Visibility = Visibility.Hidden;
        }

        //This method handles the interactions for the teabag button and shows the teastring.
        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.AddTeabag();
            TeabagString.Visibility = Visibility.Visible;
        }

        //This method handles the interactions for the grounded coffee button.
        private void Coffee_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.AddGroundedCoffee(14);
        }

        //This method handles the interactions for the water button.
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.AddWater(200);
        }

        //This method handles the interactions for the filter button.
        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.AddFilter();
        }

        //This method handles the interactions for the removeFilter button.
        private void RemoveFilter_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.RemoveFilter();
            beverageMachine.RemoveEspressoCapsule();
        }

        //This method handles the interactions for the espresso caosule button.
        private void Espresso_Click(object sender, RoutedEventArgs e)
        {
            beverageMachine.AddEspressoCapsule();
        }

        //This method shows the current status of the machine and then runs the backgroundworker and sets the machine status to not brewing if the machine is currently brewing.
        public void BeverageStatus()
        {
            Display.Content = beverageMachine.Status;
            if (beverageMachine.Brewing == true)
            {               
                backgroundWorker.RunWorkerAsync();
                beverageMachine.MachineNotBrewing();
            }
        }
    }
}
