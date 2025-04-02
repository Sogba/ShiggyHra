using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ShiggyHra;

namespace UnitTestProject
{
    [TestClass]
    public class HerniPostavaTest
    {
        [TestMethod]
        public void PositionsInitialized()
        {
            HerniPostava postava = new HerniPostava("dezo");
            Assert.AreEqual(postava.PoziceX, 0);
            Assert.AreEqual(postava.PoziceY, 0);
            Assert.AreNotEqual(postava.PoziceX, 1);
            Assert.AreNotEqual(postava.PoziceY, 1);
        }

        [TestMethod]
        public void LevelInitialized()
        {
            HerniPostava postava = new HerniPostava("dezo");
            Assert.AreEqual(postava.Level, 1);
            Assert.AreNotEqual(postava.Level, 0);
        }

        [TestMethod]
        public void CanChangePosition()
        {
            HerniPostava postava = new HerniPostava("dezo");
            postava.ZmenaPozice(1, 1);
            Assert.AreEqual(postava.PoziceX, 1);
            Assert.AreEqual(postava.PoziceY, 1);
            Assert.AreNotEqual(postava.PoziceY, 0);
            Assert.AreNotEqual(postava.PoziceY, 0);
        }

        [TestMethod]
        public void CanUseName()
        {
            HerniPostava postava = new HerniPostava("dezo123");
            Assert.AreEqual(postava.Jmeno, "dezo123");
            Assert.AreNotEqual(postava.Jmeno, "dezo");
        }

        [TestMethod]
        public void TakesDamage()
        {
            HerniPostava postava = new HerniPostava("Dezo");
            postava.UtrziZraneni(30);
            Assert.AreEqual(70, postava.AktualniHP);
            Assert.AreNotEqual(100, postava.AktualniHP);
        }

        [TestMethod]
        public void CantHaveNegativeHP()
        {
            HerniPostava postava = new HerniPostava("Dezo");
            postava.UtrziZraneni(150);
            Assert.AreEqual(0, postava.AktualniHP);
        }

        [TestMethod]
        public void ToStringTest()
        {
            HerniPostava postava = new HerniPostava("Dezo");
            postava.ZmenaPozice(200, 520);
            postava.Level = 55;
            string expectedString = "Jmeno: Dezo, Level: 55, Pozice X: 200, Pozice Y: 520";
            Assert.AreEqual(expectedString, postava.ToString());
        }

    }
}
