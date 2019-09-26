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

        public AirportSimulatorGame()
        {
            _time = DateTime.Now;
            _offset = 1;
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
