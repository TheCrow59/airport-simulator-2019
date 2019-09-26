using System.Threading.Tasks;
using System.Windows;

namespace airport_simulator_2019
{
    public partial class MainWindow : Window
    {
        AirportSimulatorGame _game = new AirportSimulatorGame();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _game;
            Task.Run(() =>_game.run());
        }

        private void RealTime_Click(object sender, RoutedEventArgs e)
        {
            RealTime.IsEnabled = false;
            Fast.IsEnabled = true;
            VeryFast.IsEnabled = true;

            _game.SetNormalSpeed();
        }

        private void Fast_Click(object sender, RoutedEventArgs e)
        {
            RealTime.IsEnabled = true;
            Fast.IsEnabled = false;
            VeryFast.IsEnabled = true;

            _game.SetFastSpeed();
        }

        private void VeryFast_Click(object sender, RoutedEventArgs e)
        {
            RealTime.IsEnabled = true;
            Fast.IsEnabled = true;
            VeryFast.IsEnabled = false;

            _game.SetVeryFastSpeed();
        }

        private void BuyAirplane_Click(object sender, RoutedEventArgs e)
        {
            switch (MessageBox.Show("Вы уверены, что хотите выкупить этот самолет?", "Подтверждение покупки", MessageBoxButton.YesNo))
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Успех");
                    break;
            }
        }
    }
}
