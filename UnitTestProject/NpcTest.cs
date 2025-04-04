using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ShiggyHra;

namespace UnitTestProject
{
    [TestClass]
    public class NpcTest
    {

        [TestMethod]
        public void CanAttackPlayer()
        {
            Hrac hrac = new Hrac("dezo", "dezo", 0, 0, 0);
            NPC goblin = new NPC("Goblin", Prace.Nepritel, true, 5);
            goblin.Attack(hrac, 20);
            Assert.AreEqual(80, hrac.AktualniHP);
        }

        [TestMethod]
        public void HasCorrectRole()
        {
            NPC Obchodnik = new NPC("Pepa", Prace.Obchodnik);
            Assert.AreEqual(Prace.Obchodnik, Obchodnik.Role);
        }

        [TestMethod]
        public void IsBoss()
        {
            NPC boss = new NPC("Mega Goblin", Prace.Nepritel, true, 4);
            Assert.IsTrue(boss.JeBoss);
        }

        [TestMethod]
        public void CanChangePosition()
        {
            NPC Obchodnik = new NPC("Pepa", Prace.Obchodnik);
            Obchodnik.ZmenaPozice(10, 15);
            Assert.AreEqual(10, Obchodnik.PoziceX);
            Assert.AreEqual(15, Obchodnik.PoziceY);
        }

        [TestMethod]
        public void BossHasStrength()
        {
            NPC boss = new NPC("Boss", Prace.Obchodnik, true, 10);
            Assert.AreEqual(10, boss.Strength);
        }

        [TestMethod]
        public void DefaultPosition()
        {
            NPC npc = new NPC("Pepa", Prace.Obchodnik, false, 1);
            Assert.AreEqual(0, npc.PoziceX);
            Assert.AreEqual(0, npc.PoziceY);
        }

        [TestMethod]
        public void ToStringTest()
        {
            NPC npc = new NPC("Pepa", Prace.Obchodnik, false, 1);
            string expectedString = "Jmeno: Pepa, Boss: Ne, Síla: 1, Prace: Obchodník";
            Assert.AreEqual(expectedString, npc.ToString());
        }

    }
}
