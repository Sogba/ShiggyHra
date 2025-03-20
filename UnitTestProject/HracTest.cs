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

        [TestMethod]
        public void XPInitialized()
        {
            Hrac hrac = new Hrac("dezo", "dezo", 0, 0, 0);
            Assert.AreEqual(hrac.XP, 0);
            Assert.AreNotEqual(hrac.XP, 1);
        }

        [TestMethod]
        public void CanGainXP()
        {
            Hrac hrac = new Hrac("dezo", "dezo", 0, 0, 0);
            hrac.AddXP(150);
            Assert.AreEqual(150, hrac.XP);
        }

        [TestMethod]
        public void LevelUpAfterEnoughXP()
        {
            Hrac hrac = new Hrac("dezo", "dezo", 0, 0, 0);
            hrac.AddXP(100);
            Assert.AreEqual(2, hrac.Level);
        }

        [TestMethod]
        public void CanPickUpItems()
        {
            Hrac hrac = new Hrac("dezo", "dezo", 0, 0, 0);
            hrac.GrabLoot("Meč");
            Assert.IsTrue(hrac.Inventar.Contains("Meč"));
        }

        [TestMethod]
        public void CanChooseWeapon()
        {
            Hrac hrac = new Hrac("dezo", "dezo", 0, 0, 0);
            hrac.UseWeapon("Luk");
            Assert.AreEqual("Luk", hrac.AktivniZbran);
        }

        [TestMethod]
        public void CanUseStamina()
        {
            Hrac hrac = new Hrac("dezo", "dezo", 0, 0, 0);
            hrac.UseStamina(20);
            Assert.AreEqual(80, hrac.AktualniStamina);
        }

    }
}
