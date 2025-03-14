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

        }

        [TestMethod]
        public void LevelInitialized()
        {
            HerniPostava postava = new HerniPostava("dezo");
            Assert.AreEqual(postava.Level, 1);
        }

        [TestMethod]
        public void CanChangePosition()
        {
            HerniPostava postava = new HerniPostava("dezo");
            postava.ZmenaPozice(1, 1);
            Assert.AreEqual(postava.PoziceX, 1);
            Assert.AreEqual(postava.PoziceY, 1);
        }
    }
}
