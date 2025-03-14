using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiggyHra
{
    public class HerniPostava
    {
        public string Jmeno { get; set; }
        public int Level { get; set; } = 1;
        public int PoziceX { get; set; } = 0;
        public int PoziceY { get; set; } = 0;

        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public override string ToString()
        {
            return $"Jmeno: {Jmeno}, Level: {Level}, Pozice: [{PoziceX}, {PoziceY}]";
        }
    }
}
