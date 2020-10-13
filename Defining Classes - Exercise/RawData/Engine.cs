using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        public Engine(int speed, int power)
        {
            this.Power = power;
            this.Speed = speed;
            Engines = new List<Engine>();
        }

        public int Speed { get; set; }
        public int Power { get; set; }
        public List<Engine> Engines { get; set; }
    }
}
