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
        public void CanChangeXP()
        {
            Hrac hrac = new Hrac("dezo", "dezo", 0, 0, 0);
            hrac.AddXP(100);
            Assert.AreEqual(hrac.XP, 100);
            Assert.AreNotEqual(hrac.XP, 99);
            Assert.AreNotEqual(hrac.Level, 0);
            Assert.AreEqual(hrac.Level, 2);
        }

    }
}
