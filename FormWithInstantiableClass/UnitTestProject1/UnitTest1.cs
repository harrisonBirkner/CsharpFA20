using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormWithInstantiableClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSetPower()
        {
            Game myGame = new Game();
            myGame.Power = 0;
            Assert.AreEqual(1, myGame.Power);
        }

        [TestMethod]
        public void TestMethodSetGameName()
        {
            Game myGame = new Game(0, "", "", 0);

            //test pass
            Assert.AreEqual("Some Game Name", myGame.GameName);

            //test fail
            //Assert.AreEqual("", myGame.GameName);
        }
    }
}
