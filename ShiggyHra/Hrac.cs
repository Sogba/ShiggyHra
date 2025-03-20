using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiggyHra
{
    public class Hrac : HerniPostava
    {
        public string Specializace { get; set; }
        private TypObliceje Oblicej { get; set; }
        public TypVlasu Vlasy { get; set; }
        public BarvaVlasu Barva { get; set; }
        public int XP { get; set; } = 0;
        public int MaxStamina { get; set; } = 100;
        public int AktualniStamina { get; set; } = 100;
        public List<string> Inventar { get; set; } = new List<string>();
        public string AktivniZbran { get; set; }


        public Hrac(string jmeno, string specializace, TypObliceje typ, TypVlasu typVlasu, BarvaVlasu barva) : base(jmeno)
        {
        }

        public enum TypObliceje
        {
            VelkyNos,
            Usoplesk,
            MakeUp
        }

        public enum TypVlasu
        {
            Drdol,
            Culik,
            Pleska
        }

        public enum BarvaVlasu
        {
            Kastanova,
            Blond,
            Cervena
        }

        public void AddXP(int xp)
        {
        }

        public void Attack(NPC cil, int damage)
        {
        }

        public void UseStamina(int mnozstvi)
        {
        }

        public void GrabLoot(string predmet)
        {
        }

        public void UseWeapon(string nazev)
        {
        }

        public override string ToString()
        {
            return "";
        }
    }
}
