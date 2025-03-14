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
    }
}
