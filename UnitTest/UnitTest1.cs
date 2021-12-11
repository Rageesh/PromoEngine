using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using PromotionalEngine;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Scanario1()
        {
            PromoEngine PrEng = new PromoEngine();
            int result = PrEng.GetCartTotal(1);
            Assert.AreEqual(result, 100);
        }

        [TestMethod]
        public void Scanario2()
        {
            PromoEngine PrEng = new PromoEngine();
            int result = PrEng.GetCartTotal(2);
            Assert.AreEqual(result, 370);
        }

        [TestMethod]
        public void Scanario3()
        {
            PromoEngine PrEng = new PromoEngine();
            int result = PrEng.GetCartTotal(3);
            Assert.AreEqual(result, 280);
        }
        [TestMethod]
        public void Scanario4()
        {
            PromoEngine PrEng = new PromoEngine();
            int result = PrEng.GetCartTotal(4);
            Assert.AreEqual(result, 510);
        }
    }
}
