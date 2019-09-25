using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport_simulator_2019
{
    public class AirportSimulatorGame
    {
        private DateTime _time;
        private int _offset;

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

        public void run()
        {
            while (true)
            {
                _time = _time.AddSeconds(_offset);
                Thread.Sleep(1000);
            }
        }
    }
}
