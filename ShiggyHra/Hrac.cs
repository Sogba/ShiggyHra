using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiggyHra
{
    public class Hrac : HerniPostava
    {
        private TypObliceje oblicej = TypObliceje.VelkyNos;
        private TypVlasu vlasy = TypVlasu.Drdol;
        private BarvaVlasu barva = BarvaVlasu.Kastanova;
        public int XP { get; private set; } = 0;

        private string specializace;
        public string Specializace
        {
            get => specializace;
            set
            {
                List<string> povoleneSpecializace = new() { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
                if (povoleneSpecializace.Contains(value))
                    specializace = value;
                else
                    throw new ArgumentException("Neplatná specializace!");
            }
        }

        public Hrac(string jmeno, string specializace, TypObliceje oblicej, TypVlasu vlasy, BarvaVlasu barva)
            : base(jmeno)
        {
            Specializace = specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barva = barva;
        }

        public enum TypObliceje { VelkyNos, Usoplesk, MakeUp }
        public enum TypVlasu { Drdol, Culik, Pleska }
        public enum BarvaVlasu { Kastanova, Blond, Cervena }

        public void AddXP(int xp)
        {
            XP += xp;
            while (XP >= Level * 100)
            {
                XP -= Level * 100;
                Level++;
            }
        }

        public override string ToString()
        {
            return $"Jméno: {Jmeno}, Specializace: {Specializace}, Obličej: {oblicej}, Vlasy: {vlasy}, Barva vlasů: {barva}, XP: {XP}, Level: {Level}";
        }
    }
}
