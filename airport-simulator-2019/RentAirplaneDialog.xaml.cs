using System;
using System.Windows;

namespace airport_simulator_2019
{
    public partial class RentAirplaneDialog : Window
    {
        public RentAirplaneDialog()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Rent_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
