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
        public TypObliceje Oblicej { get; set; }
        public TypVlasu Vlasy { get; set; }
        public BarvaVlasu Barva { get; set; }
        public int XP { get; set; } = 0;
        public int AktualniStamina { get; set; } = 100;
        public List<string> Inventar { get; set; } = new List<string>();


        public Hrac(string jmeno, string specializace, TypObliceje typ, TypVlasu typVlasu, BarvaVlasu barva) : base(jmeno)
        {
            Jmeno = jmeno;
            Specializace = specializace;
            Oblicej = typ;
            Vlasy = typVlasu;
            Barva = barva;
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
            XP += xp;
            if (XP / (Level * 100) >= 1)
                Level++;
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
