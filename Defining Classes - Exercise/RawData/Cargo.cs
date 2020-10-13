using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
            Cargos = new List<Cargo>();
        }
        public int Weight { get; set; }
        public string Type { get; set; }
        public List<Cargo> Cargos { get; set; }
    }
}
