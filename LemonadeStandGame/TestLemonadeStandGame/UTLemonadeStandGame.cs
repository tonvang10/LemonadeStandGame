using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStandGame.cs;

namespace TestLemonadeStandGame
{
    [TestClass]
    public class UTLemonadeStandGame
    { 
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            Player player = new Player();
            Inventory inventory = new Inventory();
            player.lemonUsed = 30;
            player.lemonPurchased = 50;
            //Act
            player.UseLemon();
            //Assert
            Assert.IsTrue(player.lemonPurchased > player.lemonUsed);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            Player player = new Player();
            Money money = new Money();
            player.lemonPurchased = 10;
            player.balanceOfMoney = money.GetMoney() - (player.lemonPurchased * Lemon.cost);
            //act
            player.BuyLemon();
            //assert
            Assert.IsTrue(player.balanceOfMoney > 0);
        }
        [TestMethod]
        public void TestMethod2()
        {

        }
        [TestMethod]
        public void TestMethod1()
        {

        }    
    }
}
