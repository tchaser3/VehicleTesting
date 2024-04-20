/* Title:           Vehicle Testin g
 * Date:            6-20-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using NewVehicleDLL;

namespace VehicleTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //setting up the classes
        WPFMessagesClass TheMessagesClass = new WPFMessagesClass();
        VehicleClass TheVehicleClass = new VehicleClass();

        VehiclesDataSet TheVehiclesDataSet = new VehiclesDataSet();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                TheVehiclesDataSet = TheVehicleClass.GetVehiclesInfo();

                dgrVehicles.ItemsSource = TheVehiclesDataSet.vehicles;
            }
            catch (Exception Ex)
            {
                TheMessagesClass.ErrorMessage(Ex.ToString());
            }
        }
    }
}
