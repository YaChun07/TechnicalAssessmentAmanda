
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kataPoker
{
    [TestClass]
    public class kataPoker
    {
        [TestMethod]
        public void tie()
        {
            string expect = "White wins. -With high card: Ace";
            Assert.AreEqual(expect, KataPokerHanders.compare("Black:2H 3D 5S 9C KD White: 2C 3H 4S 8C AH"));
        }
    }
}
