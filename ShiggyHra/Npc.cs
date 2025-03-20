using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiggyHra
{
    public enum Prace { Obchodník, Nepřítel, Obyvatel }

    public class NPC : HerniPostava
    {
        public Prace Role { get; set; }
        public bool JeBoss { get; set; }
        public int Strength { get; set; }

        public NPC(string jmeno, Prace role, bool jeBoss, int Strength) : base(jmeno)
        {

        }

        public NPC(string jmeno, Prace role) : base(jmeno)
        {

        }

        public void ChangePosition(int x, int y)
        {
        }

        public void Attack(Hrac cil, int damage)
        {
        }

        public override string ToString()
        {
            return "";
        }
    }
}
