using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace airport_simulator_2019
{
    public class AirportSimulatorGame : INotifyPropertyChanged
    {
        private DateTime _time;
        private int _offset;
        private int _balance;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public DateTime Time
        {
            get
            {
                return _time;
            }

            set
            {
                _time = value;
                OnPropertyChanged("Time");
            }
        }

        public int Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
                OnPropertyChanged("Balance");
            }
        }

        public AirportSimulatorGame()
        {
            _offset = 1;
            Time = DateTime.Now;
            Balance = 1000000;
        }

        public void SetNormalSpeed()
        {
            _offset = 1;
        }

        public void SetFastSpeed()
        {
            _offset = 60;
        }

        public void SetVeryFastSpeed()
        {
            _offset = 3600;
        }

        public async void run()
        {
            while (true)
            {
                Time = Time.AddSeconds(_offset);
                await Task.Delay(1000);
            }
        }
    }
}
