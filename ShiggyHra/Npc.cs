using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiggyHra
{
    public enum Prace { Obchodnik, Nepritel, Obyvatel }

    public class NPC : HerniPostava
    {
        public Prace Role { get; set; }
        public bool JeBoss { get; set; }
        public int Strength { get; set; }

        public NPC(string jmeno, Prace role, bool jeBoss, int strength) : base(jmeno)
        {
            Role = role;
            JeBoss = jeBoss;
            Strength = strength;
        }

        public NPC(string jmeno, Prace role) : base(jmeno)
        {
            Role = role;
            JeBoss = false;
            Strength = 0;  // Implicitní hodnota, pokud není síla zadána
        }

        public void Attack(Hrac cil, int damage)
        {
            // Implementace útoku
        }

        public sealed override void ZmenaPozice()
        {
            Console.WriteLine("NPC má statickou pozici a nemůže být změněno.");
        }

        public override string ToString()
        {
            return $"Jméno: {Jmeno}, Boss: {(JeBoss ? "Ano" : "Ne")}, Síla: {Strength}, Práce: {Role}";
        }
    }
}