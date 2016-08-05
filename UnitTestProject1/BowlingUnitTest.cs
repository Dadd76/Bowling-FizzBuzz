using System;
using NUnit.Framework;
using Bowling;

namespace UnitTestProject1
{
    [TestFixture]
    public class BowlingUnitTest
    {
        [Test]
        public void TestBasicScoring(  )
        {
            Game myGame = new Game("11111111111111111111");
            Assert.AreEqual(myGame.total(), 20 );
        }


        [Test]
        public void TestAllStrikeScoring()
        {
            Game myGame = new Game("XXXXXXXXXXXX");
            Assert.AreEqual(myGame.total(), 300);
        }

        [Test]
        public void TestAllStrikeThenMissScoring()
        {
            Game myGame = new Game("XXXXXXXXXX--");
            Assert.AreEqual(myGame.total(), 270);
        }

        [Test]
        public void TestAllSpare()
        {
            Game myGame = new Game("1/1/1/1/1/1/1/1/1/1/1");
            Assert.AreEqual(myGame.total(), 110);
        }
    }
}

