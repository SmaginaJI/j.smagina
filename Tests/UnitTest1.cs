using System;
using Lesson5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Account CurrentAccount1 = new DepositAccount("Рогатнев", "Сергей");
            decimal AddSum = 1000;

            //act
            CurrentAccount1.DepositMoney(AddSum);

            //assert
            Assert.AreEqual(AddSum, CurrentAccount1.Amount);
        }
    }
}
