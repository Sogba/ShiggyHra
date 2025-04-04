using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiggyHra
{
    public class HerniPostava
    {
        private string jmeno;
        private int level;
        private int poziceX;
        private int poziceY;
        private int aktualniHP;

        public string Jmeno
        {
            get { return jmeno; }
            set
            {
                if (value.Length > 10)
                    throw new Exception("Příliš dlouhé jméno");

                jmeno = value;
            }
        }
        public int Level { get { return level; } set { level = value; } }
        public int PoziceX { get { return poziceX; } private set { poziceX = value; } }
        public int PoziceY { get { return poziceY; } private set { poziceY = value; } }
        public int AktualniHP { get { return aktualniHP; } set{ aktualniHP = value; if (aktualniHP < 0) aktualniHP = 0; } }

        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
            PoziceX = 0;
            PoziceY = 0;
            Level = 1;
            AktualniHP = 100;
        }

        public virtual void ZmenaPozice(int x, int y)
        {
            PoziceX = x;
            PoziceY = y;
        }

        public void UtrziZraneni(int damage)
        {
            AktualniHP -= damage;
        }

        public override string ToString()
        {
            return $"Jmeno: {Jmeno}, Level: {Level}, Pozice X: {PoziceX}, Pozice Y: {PoziceY}";
        }
    }
}
