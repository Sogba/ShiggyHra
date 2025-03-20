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
        public int PoziceX { get; private set; }
        public int PoziceY { get; private set; }
        public int MaxHP { get; set; }
        public int AktualniHP { get; set; }
        public int Armor { get; set; }

        public HerniPostava(string jmeno)
        {

        }

        public void ZmenaPozice(int x, int y)
        {
        }

        public void UtrziZraneni(int damage)
        {
        }

        public override string ToString()
        {
            return "";
        }
    }
}
