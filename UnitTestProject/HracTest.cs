using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ShiggyHra;

namespace UnitTestProject
{
    [TestClass]
    public class HracTest
    {

        [TestMethod]
        public void SpecializaceTest()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Hrac hrac = new Hrac("dezo", "dezo", 0, 0, 0);
            });
        }

        public void HracConstructor()
        {
            Hrac hrac = new Hrac("dezo", "Kouzelník", Hrac.TypObliceje.Usoplesk, Hrac.TypVlasu.Drdol, Hrac.BarvaVlasu.Blond);
            Assert.AreEqual(hrac.Jmeno, "dezo");
            Assert.AreEqual(hrac.Specializace, "aaa");
            Assert.AreEqual(hrac.Vlasy, 1);
            Assert.AreEqual(hrac.Oblicej, 2);
            Assert.AreEqual(hrac.Barva, 2);
        }

        [TestMethod]
        public void XPInitialized()
        {
            Hrac hrac = new Hrac("dezo", "Kouzelník", 0, 0, 0);
            Assert.AreEqual(hrac.XP, 0);
            Assert.AreNotEqual(hrac.XP, 1);
        }

        [TestMethod]
        public void CanGainXP()
        {
            Hrac hrac = new Hrac("dezo", "Kouzelník", 0, 0, 0);
            hrac.AddXP(150);
            Assert.AreEqual(150, hrac.XP);
        }

        [TestMethod]
        public void LevelUpAfterEnoughXP()
        {
            Hrac hrac = new Hrac("dezo", "Kouzelník", 0, 0, 0);
            hrac.AddXP(100);
            Assert.AreEqual(2, hrac.Level);
        }
    }
}
