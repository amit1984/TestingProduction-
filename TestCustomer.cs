using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Production.Interface;
using Production.services;

namespace UnitTestProduction
{
    [TestClass]
    public class TestCustomer
    {
        [TestMethod]
        public void TestgetBudget()
        {
            Mock<ICustomerService> gb = new Mock<ICustomerService>();
            var fakeObject = new Mock<ICustomerService>();
            fakeObject.Setup(x => x.getBudget(It.IsAny<int>())).Returns(true);
            var Res = fakeObject.Object.getBudget(1);

            Assert.AreEqual(Res,true);        

        }
        [TestMethod]
        public void UnitgetBudget()
        {
            var obj = new customerService();
            var res = obj.getcustomer(1);
            Assert.AreEqual(res, true);
        }
    }
}
