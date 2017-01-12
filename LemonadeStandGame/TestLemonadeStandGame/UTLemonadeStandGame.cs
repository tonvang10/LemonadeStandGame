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
            Recipe recipe = new Recipe();
            Player player = new Player();
            Inventory inventory = new Inventory();
            recipe.lemonUsed = 30;
           
            //Act
            player.UseLemon();
            //Assert
            Assert.IsTrue(recipe.lemonUsed < Convert.ToInt32(inventory.lemons));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            Player player = new Player();
            Store store = new Store();
            Money money = new Money();
            store.lemonToPurchase = 10;
            money.money = money.money - (store.lemonToPurchase * Lemon.cost);
            //act
            player.BuyLemon();
            //assert
            Assert.IsTrue(money.money > 0);
        }
        //[TestMethod]
        //public void TestMethod2()
        //{

        //}
        //[TestMethod]
        //public void TestMethod1()
        //{

        //}    
    }
}
